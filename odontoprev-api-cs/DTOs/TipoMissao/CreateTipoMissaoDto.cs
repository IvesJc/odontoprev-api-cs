namespace odontoprev_api_cs.DTOs.TipoMissao
{
    public class CreateTipoMissaoDto
    {
        public required string Titulo { get; set; }

        public required int DuracaoPadraoDias { get; set; }

        public required int RecompensaPadrao { get; set; }

        public FrequenciaEnum Frequencia { get; set; }
    }
}
