namespace odontoprev_api_cs.DTOs.Missao
{
    public class MissaoDto
    {
        public int Id { get; set; }

        public required int Concluido { get; set; }

        public int RecompensaRecebida { get; set; }

        public required DateTime ExpiraEm { get; set; }

        public required int TipoMissaoId { get; set; }

        public required int BeneficiarioId { get; set; }
    }
}
