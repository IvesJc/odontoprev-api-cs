using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoprev_api_cs.Entities
{
    [Table("tb_tipo_servico")]
    public class TipoServicoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Nome { get; set; }

        [Required]
        public required double ValorReais { get; set; }

        public virtual ICollection<TipoPlanoEntity>? TipoPlanos { get; set; }
        public virtual ICollection<ServicoEntity>? Servicos { get; set; }
        public virtual ICollection<PrestadorServicoEntity>? PrestadorServicos { get; set; }
    }
}
