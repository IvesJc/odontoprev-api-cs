using odontoprev_api_cs.DTOs.Servico;

namespace odontoprev_api_cs.Mappers.Servico;

public static class ServicoMapper
{
    public static ServicoDto ToServicoDto(this Entities.Servico servico)
    {
        return new ServicoDto
        {
            Id = servico.Id,
            SinistroId = servico.SinistroId,
            TipoServicoId = servico.TipoServicoId,
            ValorPago = servico.ValorPago,
        };
    }

    public static Entities.Servico ToServicoFromCreate(this CreateServicoDto dto)
    {
        return new Entities.Servico
        {
            SinistroId = dto.SinistroId,
            TipoServicoId = dto.TipoServicoId,
            ValorPago = dto.ValorPago
        };
    }
    public static Entities.Servico ToServicoFromUpdate(this UpdateServicoDto dto)
    {
        return new Entities.Servico
        {
            SinistroId = dto.SinistroId,
            TipoServicoId = dto.TipoServicoId,
            ValorPago = dto.ValorPago
        };
    }
}