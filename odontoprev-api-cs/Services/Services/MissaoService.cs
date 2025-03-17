using odontoprev_api_cs.DTOs.Missao;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Missao;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class MissaoService(IMissaoRepository missaoRepository) : IMissaoService
{
    public async Task<List<Missao>> GetAllMissaosAsync()
    {
        return await missaoRepository.GetAllMissaosAsync();
    }

    public async Task<Missao?> GetMissaoByIdAsync(int id)
    {
        return await missaoRepository.GetMissaoByIdAsync(id);
    }

    public async Task<Missao> CreateMissaoAsync(CreateMissaoDto createMissaoDto)
    {
        var missao = createMissaoDto.ToMissaoFromCreate();
        await missaoRepository.CreateMissaoAsync(missao);
        return missao;
    }

    public async Task<Missao?> UpdateMissaoByAsync(int id, UpdateMissaoDto updateMissaoDto)
    {
        return await missaoRepository.UpdateMissaoByAsync(id, updateMissaoDto);
    }

    public async Task<bool> DeleteMissaoByAsync(int id)
    {
        var missao = await missaoRepository.DeleteMissaoByAsync(id);
        return missao != null;
    }
}