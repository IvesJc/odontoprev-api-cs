namespace odontoprev_api_cs.DTOs.PrestadorServico
{
    public enum EspecialidadeEnum
    {
        Ortodontia,
        Odontopediatria,
        Odontologia,
        Implantologia,
        Estomatologia,
        Periodontia,
        OdontologiaEstetica,
    }

    public class PrestadorServicoDto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required int NumeroCro { get; set; }

        public required EspecialidadeEnum Especialidade { get; set; }

        public required string NumeroContrato { get; set; }

        public int? Avaliacao { get; set; }

        public required int RedeCredenciadaId { get; set; }
    }
}
