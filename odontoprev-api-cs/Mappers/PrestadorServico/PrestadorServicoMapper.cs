using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Mappers.PrestadorServico;

public static class PrestadorServicoMapper
{
    public static PrestadorServicoDto ToPrestadorServicoDto(this Entities.PrestadorServico prestadorServico)
    {
        return new PrestadorServicoDto
        {
            Id = prestadorServico.Id,
            Especialidade = (int)prestadorServico.Especialidade,
            Nome = prestadorServico.Nome,
            NumeroContrato = prestadorServico.NumeroContrato,
            NumeroCro = prestadorServico.NumeroCro,
            RedeCredenciadaId = prestadorServico.RedeCredenciadaId,
            Avaliacao = prestadorServico.Avaliacao,
        };
    }

    public static Entities.PrestadorServico ToPrestadorServicoFromCreate(this CreatePrestadorServicoDto dto)
    {
        return new Entities.PrestadorServico
        {
            Especialidade = (EspecialidadeEnum)dto.Especialidade,
            Nome = dto.Nome,
            NumeroContrato = dto.NumeroContrato,
            NumeroCro = dto.NumeroCro,
            RedeCredenciadaId = dto.RedeCredenciadaId,
            Avaliacao = dto.Avaliacao,
        };
    }
    public static Entities.PrestadorServico ToPrestadorServicoFromUpdate(this UpdatePrestadorServicoDto dto)
    {
        return new Entities.PrestadorServico
        {
            Especialidade = (EspecialidadeEnum)dto.Especialidade,
            Nome = dto.Nome,
            NumeroContrato = dto.NumeroContrato,
            NumeroCro = dto.NumeroCro,
            RedeCredenciadaId = dto.RedeCredenciadaId,
            Avaliacao = dto.Avaliacao,
        };
    }
}