﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoprev_api_cs.DTOs.TipoPlano
{
    public class CreateTipoPlanoDto
    {
        public required string Nome { get; set; }

        public required string Tipo { get; set; }

        public required double Preco { get; set; }

        public required int CarenciaDias { get; set; }

        public required int ValidadeDias { get; set; }
    }
}
