using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoprev_api_cs.DTOs.TipoPlano
{
    public enum TipoEnum
    {
        IndividualEFamiliar,
        PMEeMEI,
        Empresarial
    }

    public class TipoPlanoDto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required string Tipo { get; set; }

        public required double Preco { get; set; }

        public required int CarenciaDias { get; set; }

        public required int ValidadeDias { get; set; }
    }
}
