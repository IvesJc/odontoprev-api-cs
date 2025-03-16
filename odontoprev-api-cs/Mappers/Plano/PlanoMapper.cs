using odontoprev_api_cs.DTOs.Plano;

namespace odontoprev_api_cs.Mappers.Plano;

public static class PlanoMapper
{
    public static PlanoDto ToPlanoDto(this Entities.Plano plano)
    {
        return new PlanoDto
        {
            Id = plano.Id,
            DataExpiracao = plano.DataExpiracao,
            PrecoCobrado = plano.PrecoCobrado,
            TipoPlanoId = plano.TipoPlanoId,
            EmpresaContratanteId = plano.EmpresaContratanteId,
            DataFinalCarencia = plano.DataFinalCarencia,
        };
    }

    public static Entities.Plano ToPlanoFromCreate(this CreatePlanoDto dto)
    {
        return new Entities.Plano
        {
            DataExpiracao = dto.DataExpiracao,
            PrecoCobrado = dto.PrecoCobrado,
            TipoPlanoId = dto.TipoPlanoId,
            EmpresaContratanteId = dto.EmpresaContratanteId,
            DataFinalCarencia = dto.DataFinalCarencia,
        };
    }
    public static Entities.Plano ToPlanoFromUpdate(this UpdatePlanoDto dto)
    {
        return new Entities.Plano
        {
            DataExpiracao = dto.DataExpiracao,
            PrecoCobrado = dto.PrecoCobrado,
            TipoPlanoId = dto.TipoPlanoId,
            EmpresaContratanteId = dto.EmpresaContratanteId,
            DataFinalCarencia = dto.DataFinalCarencia,
        };
    }
}