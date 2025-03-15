namespace odontoprev_api_cs.DTOs.Plano
{
    public class CreatePlanoDto
    {
        public required DateTime DataExpiracao { get; set; }

        public required double PrecoCobrado { get; set; }

        public DateTime? DataFinalCarencia { get; set; }

        public required int TipoPlanoId { get; set; }

        public int EmpresaContratanteId { get; set; }

    }
}
