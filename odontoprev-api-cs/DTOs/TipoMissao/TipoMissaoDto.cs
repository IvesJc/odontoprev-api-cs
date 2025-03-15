namespace odontoprev_api_cs.DTOs.TipoMissao
{
    public enum FrequenciaEnum
    {
        Diaria,
        Semanal,
        Mensal,
        Trimestral,
    }

    public class TipoMissaoDto
    {
        public int Id { get; set; }

        public required string Titulo { get; set; }

        public required int DuracaoPadraoDias { get; set; }

        public required int RecompensaPadrao { get; set; }

        public FrequenciaEnum Frequencia { get; set; }
    }
}
