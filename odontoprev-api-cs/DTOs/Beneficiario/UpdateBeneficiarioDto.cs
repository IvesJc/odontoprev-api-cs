namespace odontoprev_api_cs.DTOs.Beneficiario{
    
    public class UpdateBeneficiarioDto
    {
        public required string Nome { get; set; }

        public required string Password { get; set; }

        public required string Cpf { get; set; }

        public required int Tipo { get; set; }

        public required string Telefone { get; set; }

        public required DateTime DataAdesao { get; set; }

        public string? FotoUrl { get; set; }

        public string? NumeroContrato { get; set; }

        public int? EnderecoId { get; set; }

        public int? EmpresaContratanteId { get; set; }
    }
}
