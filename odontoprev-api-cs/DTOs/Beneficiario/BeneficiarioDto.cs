namespace odontoprev_api_cs.DTOs.Beneficiario{
    public enum TipoBeneficiarioEnum
    {
        Pessoal,
        Empresa,
        Familiar, // Para planos familiares, onde o contratante terá o tipo Pessoal, e o familiar terá o tipo Familiar
    }

    public class BeneficiarioDto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required string Password { get; set; }

        public required string Cpf { get; set; }

        public required TipoBeneficiarioEnum Tipo { get; set; }

        public required string Telefone { get; set; }

        public required DateTime DataAdesao { get; set; }

        public string? FotoUrl { get; set; }

        public string? NumeroContrato { get; set; }

        public int? EnderecoId { get; set; }

        public int? EmpresaContratanteId { get; set; }
    }
}
