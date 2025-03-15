namespace odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus
{
    public class CreateProgramaRelacionamentoStatusDto
    {

        public required int QtdePontos { get; set; }

        public required DateTime DataAdesao { get; set; }

        public required int BeneficiarioId { get; set; }
    }
}
