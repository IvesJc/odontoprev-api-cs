using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoprev_api_cs.Entities
{
    public enum FrequenciaEnum
    {
        Diaria,
        Semanal,
        Mensal,
        Trimestral,
    }

    [Table("tb_tipo_missao")]
    public class TipoMissao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string Titulo { get; set; }

        [Required]
        public required int DuracaoPadraoDias { get; set; }

        [Required]
        public required int RecompensaPadrao { get; set; }

        [Required]
        [EnumDataType(typeof(FrequenciaEnum))]
        public FrequenciaEnum Frequencia { get; set; }

        // public virtual ICollection<MissaoEntity>? Missoes { get; set; }
    }
}
