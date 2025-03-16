using odontoprev_api_cs.DTOs.TipoPlano;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Mappers.TipoPlano;

public static class TipoPlanoMapper
{
    public static TipoPlanoDto ToTipoPlanoDto(this Entities.TipoPlano tipoPlano)
    {
        return new TipoPlanoDto
        {
            Id = tipoPlano.Id,
            Nome = tipoPlano.Nome,
            Preco = tipoPlano.Preco,
            Tipo = (int)tipoPlano.Tipo,
            CarenciaDias = tipoPlano.CarenciaDias,
            ValidadeDias = tipoPlano.ValidadeDias,
        };
    }

    public static Entities.TipoPlano ToTipoPlanoFromCreate(this CreateTipoPlanoDto dto)
    {
        return new Entities.TipoPlano
        {
            Nome = dto.Nome,
            Preco = dto.Preco,
            Tipo = (TipoEnum)dto.Tipo,
            CarenciaDias = dto.CarenciaDias,
            ValidadeDias = dto.ValidadeDias,
        };
    }
    public static Entities.TipoPlano ToTipoPlanoFromUpdate(this UpdateTipoPlanoDto dto)
    {
        return new Entities.TipoPlano
        {
            Nome = dto.Nome,
            Preco = dto.Preco,
            Tipo = (TipoEnum)dto.Tipo,
            CarenciaDias = dto.CarenciaDias,
            ValidadeDias = dto.ValidadeDias,
        };
    }
}