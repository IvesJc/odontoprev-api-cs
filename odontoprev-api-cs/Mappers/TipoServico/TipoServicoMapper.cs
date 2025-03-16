using odontoprev_api_cs.DTOs.RedeCredenciada;

namespace odontoprev_api_cs.Mappers.TipoServico;

public static class RedeCredenciadaMapper
{
    public static RedeCredenciadaDto ToRedeCredenciadaDto(this Entities.RedeCredenciada redeCredenciada)
    {
        return new RedeCredenciadaDto
        {
            Id = redeCredenciada.Id,
            Nome = redeCredenciada.Nome,
        };
    }

    public static Entities.RedeCredenciada ToRedeCredenciadaFromCreate(this CreateRedeCredenciadaDto dto)
    {
        return new Entities.RedeCredenciada
        {
            Nome = dto.Nome,
        };
    }
    public static Entities.RedeCredenciada ToRedeCredenciadaFromUpdate(this UpdateRedeCredenciadaDto dto)
    {
        return new Entities.RedeCredenciada
        {
            Nome = dto.Nome,
        };
    }
}