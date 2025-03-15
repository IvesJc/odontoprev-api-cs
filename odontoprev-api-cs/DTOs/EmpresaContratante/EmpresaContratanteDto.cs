namespace odontoprev_api_cs.DTOs.EmpresaContratante
{
    public class EmpresaContratanteDto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required string Cnpj { get; set; }

        public required string NumeroContrato { get; set; }

    }
}
