using odontoprev_api_cs.DTOs.RedeCredenciada;
using odontoprev_api_cs.DTOs.TipoServico;

namespace odontoprev_api_cs.Mappers.TipoServico;

public static class RedeCredenciadaMapper
{
    public static TipoServicoDto ToTipoServicoDto(this Entities.TipoServico tipoServico)
    {
        return new TipoServicoDto
        {
            Id =  tipoServico.Id,
            Nome = tipoServico.Nome,
            ValorReais =  tipoServico.ValorReais,
        };
    }

    public static Entities.TipoServico ToTipoServicoFromCreate(this CreateTipoServicoDto dto)
    {
        return new Entities.TipoServico
        {
            Nome = dto.Nome,
            ValorReais = dto.ValorReais,
        };
    }
    public static Entities.TipoServico ToTipoServicoFromUpdate(this UpdateTipoServicoDto dto)
    {
        return new Entities.TipoServico
        {
            Nome = dto.Nome,
            ValorReais = dto.ValorReais,
        };
    }
}