using Microsoft.ML.Data;

namespace odontoprev_api_cs.Entities;

public class DentalPrediction
{
    [ColumnName("PredictedLabel")]
    public string DiagnosticoPrevisto;
}