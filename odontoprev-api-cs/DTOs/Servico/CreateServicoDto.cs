namespace odontoprev_api_cs.DTOs.Servico
{
    public class CreateServicoDto
    {
        public double ValorPago { get; set; }

        public required int TipoServicoId { get; set; }

        public required int SinistroId { get; set; }
    }
}
