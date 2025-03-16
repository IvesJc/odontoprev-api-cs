using odontoprev_api_cs.DTOs.Sinistro;

namespace odontoprev_api_cs.Mappers.Sinistro;

public static class SinistroMapper
{
    public static SinistroDto ToSinistroDto(this Entities.Sinistro sinistro)
    {
        return new SinistroDto
        {
            Id = sinistro.Id,
            BeneficiarioId = sinistro.BeneficiarioId,
            DataAutorizacao = sinistro.DataAutorizacao,
            DataSolicitacao = sinistro.DataSolicitacao,
            PrestadorServicoId = sinistro.PrestadorServicoId,
            ValorPagoParaPrestador = sinistro.ValorPagoParaPrestador,
        };
    }

    public static Entities.Sinistro ToSinistroFromCreate(this CreateSinistroDto dto)
    {
        return new Entities.Sinistro
        {
            BeneficiarioId = dto.BeneficiarioId,
            DataAutorizacao = dto.DataAutorizacao,
            DataSolicitacao = dto.DataSolicitacao,
            PrestadorServicoId = dto.PrestadorServicoId,
            ValorPagoParaPrestador = dto.ValorPagoParaPrestador,
        };
    }
    public static Entities.Sinistro ToSinistroFromUpdate(this UpdateSinistroDto dto)
    {
        return new Entities.Sinistro
        {
            BeneficiarioId = dto.BeneficiarioId,
            DataAutorizacao = dto.DataAutorizacao,
            DataSolicitacao = dto.DataSolicitacao,
            PrestadorServicoId = dto.PrestadorServicoId,
            ValorPagoParaPrestador = dto.ValorPagoParaPrestador,
        };
    }
}