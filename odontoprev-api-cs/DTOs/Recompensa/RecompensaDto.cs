namespace odontoprev_api_cs.DTOs.Recompensa
{
    public class RecompensaDto
    {
        public int Id { get; set; }

        public required DateTime ResgatadoEm { get; set; }

        public required DateTime ExpiraEm { get; set; }

        public required int BeneficiarioId { get; set; }

        public required int TipoRecompensaId { get; set; }
    }
}
