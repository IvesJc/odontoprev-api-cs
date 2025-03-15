namespace odontoprev_api_cs.DTOs.Servico
{
    public class ServicoDto
    {
        public int Id { get; set; }

        public double ValorPago { get; set; }

        public required int TipoServicoId { get; set; }

        public required int SinistroId { get; set; }
    }
}
