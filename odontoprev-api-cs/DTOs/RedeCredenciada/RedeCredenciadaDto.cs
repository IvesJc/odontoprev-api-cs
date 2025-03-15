using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoprev_api_cs.DTOs.RedeCredenciada
{
    public class RedeCredenciadaDto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }
    }
}
