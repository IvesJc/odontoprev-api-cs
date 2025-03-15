namespace odontoprev_api_cs.DTOs.TipoServico
{
    public class TipoServicoDto
    {
        public int Id { get; set; }
        
        public required string Nome { get; set; }

        public required double ValorReais { get; set; }
    }
}
