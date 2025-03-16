using odontoprev_api_cs.DTOs.TipoMissao;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Mappers.TipoMissao;

public static class TipoMissaoMapper
{
    public static TipoMissaoDto ToMissaoDto(this Entities.TipoMissao tipoMissao)
    {
        return new TipoMissaoDto
        {
            Id = tipoMissao.Id,
            Titulo = tipoMissao.Titulo,
            RecompensaPadrao = tipoMissao.RecompensaPadrao,
            DuracaoPadraoDias = tipoMissao.DuracaoPadraoDias,
            Frequencia = (int)tipoMissao.Frequencia,
        };
    }

    public static Entities.TipoMissao ToMissaoFromCreate(this CreateTipoMissaoDto dto)
    {
        return new Entities.TipoMissao
        {
            Titulo = dto.Titulo,
            RecompensaPadrao = dto.RecompensaPadrao,
            DuracaoPadraoDias = dto.DuracaoPadraoDias,
            Frequencia = (FrequenciaEnum)dto.Frequencia,
        };
    }
    public static Entities.TipoMissao ToMissaoFromUpdate(this UpdateTipoMissaoDto dto)
    {
        return new Entities.TipoMissao
        {
            Titulo = dto.Titulo,
            RecompensaPadrao = dto.RecompensaPadrao,
            DuracaoPadraoDias = dto.DuracaoPadraoDias,
            Frequencia = (FrequenciaEnum)dto.Frequencia,
        };
    }
}