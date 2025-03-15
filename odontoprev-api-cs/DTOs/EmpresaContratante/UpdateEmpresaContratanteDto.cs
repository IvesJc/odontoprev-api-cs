namespace odontoprev_api_cs.DTOs.EmpresaContratante
{
    public class UpdateEmpresaContratanteDto
    {
        public required string Nome { get; set; }

        public required string Cnpj { get; set; }

        public required string NumeroContrato { get; set; }

    }
}
