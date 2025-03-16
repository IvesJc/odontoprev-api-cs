using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Mappers.TipoRecompensa;

public static class TipoRecompensaMapper
{
    public static TipoRecompensaDto ToTipoRecompensaDto(this Entities.TipoRecompensa tipoRecompensa)
    {
        return new TipoRecompensaDto
        {
            Id = tipoRecompensa.Id,
            Aplicacao = (int)tipoRecompensa.Aplicacao,
            Nome = tipoRecompensa.Nome,
            ExpiracaoDias = tipoRecompensa.ExpiracaoDias,
        };
    }

    public static Entities.TipoRecompensa ToTipoRecompensaFromCreate(this CreateTipoRecompensaDto dto)
    {
        return new Entities.TipoRecompensa
        {
            Aplicacao = (AplicacaoEnum)dto.Aplicacao,
            Nome = dto.Nome,
            ExpiracaoDias = dto.ExpiracaoDias,
        };
    }
    public static Entities.TipoRecompensa ToTipoRecompensaFromUpdate(this UpdateTipoRecompensaDto dto)
    {
        return new Entities.TipoRecompensa
        {
            Aplicacao = (AplicacaoEnum)dto.Aplicacao,
            Nome = dto.Nome,
            ExpiracaoDias = dto.ExpiracaoDias,
        };
    }
}