﻿namespace odontoprev_api_cs.DTOs.Sinistro
{
    public class SinistroDto
    {
        public int Id { get; set; }

        public required DateTime DataSolicitacao { get; set; }

        public required DateTime DataAutorizacao { get; set; }

        public double? ValorPagoParaPrestador { get; set; }

        public required int BeneficiarioId { get; set; }

        public required int PrestadorServicoId { get; set; }
    }
}
