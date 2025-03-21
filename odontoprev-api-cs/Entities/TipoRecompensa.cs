﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoprev_api_cs.Entities
{
    public enum AplicacaoEnum
    {
        Mensalidade,
        Produto,
    }

    [Table("tb_tipo_recompensa")]
    public class TipoRecompensa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nome { get; set; }

        [Required]
        public required int ExpiracaoDias { get; set; }

        [Required]
        [EnumDataType(typeof(AplicacaoEnum))]
        public required AplicacaoEnum Aplicacao { get; set; }

        // public virtual ICollection<RecompensaEntity>? Recompensas { get; set; }
    }
}
