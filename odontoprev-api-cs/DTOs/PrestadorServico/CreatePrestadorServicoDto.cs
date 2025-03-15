namespace odontoprev_api_cs.DTOs.PrestadorServico
{
    public class CreatePrestadorServicoDto
    {
        public required string Nome { get; set; }

        public required int NumeroCro { get; set; }

        public required EspecialidadeEnum Especialidade { get; set; }

        public required string NumeroContrato { get; set; }

        public int? Avaliacao { get; set; }

        public required int RedeCredenciadaId { get; set; }
    }
}
