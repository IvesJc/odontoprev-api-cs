﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoprev_api_cs.Entities
{
    [Table("tb_endereco")]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string Rua { get; set; }

        [Required]
        public required int Numero { get; set; }

        [Required]
        [StringLength(200)]
        public required string Cidade { get; set; }

        [Required]
        [StringLength(200)]
        public required string Estado { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"^\d{5}-\d{3}$")]
        public required string Cep { get; set; }

        public string? Complemento { get; set; }

        // public virtual BeneficiarioEntity? Beneficiario { get; set; }
        // public virtual RedeCredenciadaEntity? RedeCredenciada { get; set; }
    }
}
