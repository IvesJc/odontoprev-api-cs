using Microsoft.ML;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class DentalDiagnosticoService : IDentalDiagnosticoService
{
    private const string _modelPath = "MLModels/diagnosticoModel.zip";

    public void Treinar()
    {
        var mlContext = new MLContext();

        var data = mlContext.Data.LoadFromTextFile<DentalData>("Data/dados_bucais.csv", separatorChar: ',', hasHeader: true);

        var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", "Diagnostico")
            .Append(mlContext.Transforms.Concatenate("Features", "Idade", "QtdCaries", "GengivaInflamada"))
            .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
            .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

        var model = pipeline.Fit(data);
        mlContext.Model.Save(model, data.Schema, _modelPath);
    }

    public string Prever(float idade, float qtdCaries, float gengivaInflamada)
    {
        var mlContext = new MLContext();
        var model = mlContext.Model.Load(_modelPath, out _);

        var engine = mlContext.Model.CreatePredictionEngine<DentalData, DentalPrediction>(model);

        var prediction = engine.Predict(new DentalData
        {
            Idade = idade,
            QtdCaries = qtdCaries,
            GengivaInflamada = gengivaInflamada
        });

        return prediction.DiagnosticoPrevisto;
    }
}
