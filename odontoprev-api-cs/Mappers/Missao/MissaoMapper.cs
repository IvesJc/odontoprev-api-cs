using odontoprev_api_cs.DTOs.Missao;

namespace odontoprev_api_cs.Mappers.Missao;

public static class MissaoMapper
{
    public static MissaoDto ToMissaoDto(this Entities.Missao missao)
    {
        return new MissaoDto
        {
            Id = missao.Id,
            Concluido = missao.Concluido,
            BeneficiarioId = missao.BeneficiarioId,
            ExpiraEm = missao.ExpiraEm,
            TipoMissaoId = missao.TipoMissaoId,
            RecompensaRecebida = missao.RecompensaRecebida,
        };
    }

    public static Entities.Missao ToMissaoFromCreate(this CreateMissaoDto missaoDto)
    {
        return new Entities.Missao
        {
            Concluido = missaoDto.Concluido,
            BeneficiarioId = missaoDto.BeneficiarioId,
            ExpiraEm = missaoDto.ExpiraEm,
            TipoMissaoId = missaoDto.TipoMissaoId,
            RecompensaRecebida = missaoDto.RecompensaRecebida,
        };
    }

    public static Entities.Missao ToMissaoFromUpdate(this UpdateMissaoDto missaoDto)
    {
        return new Entities.Missao
        {
            Concluido = missaoDto.Concluido,
            BeneficiarioId = missaoDto.BeneficiarioId,
            ExpiraEm = missaoDto.ExpiraEm,
            TipoMissaoId = missaoDto.TipoMissaoId,
            RecompensaRecebida = missaoDto.RecompensaRecebida,
        };
    }
}