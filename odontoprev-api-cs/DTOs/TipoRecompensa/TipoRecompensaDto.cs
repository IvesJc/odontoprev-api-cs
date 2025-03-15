namespace odontoprev_api_cs.DTOs.TipoRecompensa
{
    public enum AplicacaoEnum
    {
        Mensalidade,
        Produto,
    }

    public class TipoRecompensaDto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required int ExpiracaoDias { get; set; }

        public required AplicacaoEnum Aplicacao { get; set; }
    }
}
