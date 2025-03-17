using odontoprev_api_cs.DTOs.TipoMissao;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoMissao;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class TipoMissaoService(ITipoMissaoRepository tipoMissaoRepository) : ITipoMissaoService
{
    public async Task<List<TipoMissao>> GetAllTipoMissaosAsync()
    {
        return await tipoMissaoRepository.GetAllTipoMissaosAsync();
    }

    public async Task<TipoMissao?> GetTipoMissaoByIdAsync(int id)
    {
        return await tipoMissaoRepository.GetTipoMissaoByIdAsync(id);
    }

    public async Task<TipoMissao> CreateTipoMissaoAsync(CreateTipoMissaoDto createTipoMissaoDto)
    {
        var tipoMissao = createTipoMissaoDto.ToTipoMissaoFromCreate();
        await tipoMissaoRepository.CreateTipoMissaoAsync(tipoMissao);
        return tipoMissao;
    }

    public async Task<TipoMissao?> UpdateTipoMissaoByAsync(int id, UpdateTipoMissaoDto updateTipoMissaoDto)
    {
        return await tipoMissaoRepository.UpdateTipoMissaoByAsync(id, updateTipoMissaoDto);
    }

    public async Task<bool> DeleteTipoMissaoByAsync(int id)
    {
        var tipoMissao = await tipoMissaoRepository.DeleteTipoMissaoByAsync(id);
        return tipoMissao != null;
    }
}