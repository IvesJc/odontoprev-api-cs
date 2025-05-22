namespace odontoprev_api_cs.Services.Interfaces;

public interface IDentalDiagnosticoService
{
    public void Treinar();
    public string Prever(float idade, float qtdCaries, float gengivaInflamada);
    
}
