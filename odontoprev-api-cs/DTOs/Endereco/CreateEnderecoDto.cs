namespace odontoprev_api_cs.DTOs.Endereco
{
    public class CreateEnderecoDto
    {
        public required string Rua { get; set; }

        public required int Numero { get; set; }

        public required string Cidade { get; set; }

        public required string Estado { get; set; }

        public required string Cep { get; set; }

        public string? Complemento { get; set; }

    }
}
