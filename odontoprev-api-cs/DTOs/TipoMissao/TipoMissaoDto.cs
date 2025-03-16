namespace odontoprev_api_cs.DTOs.TipoMissao
{
    public class TipoMissaoDto
    {
        public int Id { get; set; }

        public required string Titulo { get; set; }

        public required int DuracaoPadraoDias { get; set; }

        public required int RecompensaPadrao { get; set; }

        public int Frequencia { get; set; }
    }
}
