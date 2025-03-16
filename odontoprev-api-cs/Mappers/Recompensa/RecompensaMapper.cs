using odontoprev_api_cs.DTOs.Recompensa;

namespace odontoprev_api_cs.Mappers.Recompensa;

public static class RecompensaMapper
{
    public static RecompensaDto ToRecompensaDto(this Entities.Recompensa recompensa)
    {
        return new RecompensaDto
        {
            Id = recompensa.Id,
            BeneficiarioId = recompensa.BeneficiarioId,
            ExpiraEm = recompensa.ExpiraEm,
            ResgatadoEm = recompensa.ResgatadoEm,
            TipoRecompensaId = recompensa.TipoRecompensaId,
        };
    }

    public static Entities.Recompensa ToRecompensaFromCreate(this CreateRecompensaDto dto)
    {
        return new Entities.Recompensa
        {
            BeneficiarioId = dto.BeneficiarioId,
            ExpiraEm = dto.ExpiraEm,
            ResgatadoEm = dto.ResgatadoEm,
            TipoRecompensaId = dto.TipoRecompensaId,
        };
    }
    public static Entities.Recompensa ToRecompensaFromUpdate(this UpdateRecompensaDto dto)
    {
        return new Entities.Recompensa
        {
            BeneficiarioId = dto.BeneficiarioId,
            ExpiraEm = dto.ExpiraEm,
            ResgatadoEm = dto.ResgatadoEm,
            TipoRecompensaId = dto.TipoRecompensaId,
        };
    }
}