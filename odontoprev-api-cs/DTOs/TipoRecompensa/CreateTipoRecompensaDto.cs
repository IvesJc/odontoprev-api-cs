namespace odontoprev_api_cs.DTOs.TipoRecompensa
{
    public class CreateTipoRecompensaDto
    {
        public required string Nome { get; set; }

        public required int ExpiracaoDias { get; set; }

        public required int Aplicacao { get; set; }
    }
}
