namespace odontoprev_api_cs.DTOs.TipoPlano
{
    public class UpdateTipoPlanoDto
    {
        public required string Nome { get; set; }

        public required int Tipo { get; set; }

        public required double Preco { get; set; }

        public required int CarenciaDias { get; set; }

        public required int ValidadeDias { get; set; }
    }
}
