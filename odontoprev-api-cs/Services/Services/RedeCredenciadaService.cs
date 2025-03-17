using odontoprev_api_cs.DTOs.RedeCredenciada;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.RedeCredenciada;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class RedeCredenciadaService(IRedeCredenciadaRepository redeCredenciadaRepository) : IRedeCredenciadaService
{
    public async Task<List<RedeCredenciada>> GetAllRedeCredenciadasAsync()
    {
        return await redeCredenciadaRepository.GetAllRedeCredenciadasAsync();
    }

    public async Task<RedeCredenciada?> GetRedeCredenciadaByIdAsync(int id)
    {
        return await redeCredenciadaRepository.GetRedeCredenciadaByIdAsync(id);
    }

    public async Task<RedeCredenciada> CreateRedeCredenciadaAsync(CreateRedeCredenciadaDto createRedeCredenciadaDto)
    {
        var redeCredenciada = createRedeCredenciadaDto.ToRedeCredenciadaFromCreate();
        await redeCredenciadaRepository.CreateRedeCredenciadaAsync(redeCredenciada);
        return redeCredenciada;
    }

    public async Task<RedeCredenciada?> UpdateRedeCredenciadaByAsync(int id, UpdateRedeCredenciadaDto updateRedeCredenciadaDto)
    {
        return await redeCredenciadaRepository.UpdateRedeCredenciadaByAsync(id, updateRedeCredenciadaDto);
    }

    public async Task<bool> DeleteRedeCredenciadaByAsync(int id)
    {
        var redeCredenciada = await redeCredenciadaRepository.DeleteRedeCredenciadaByAsync(id);
        return redeCredenciada != null;
    }
}