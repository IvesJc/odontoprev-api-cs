using odontoprev_api_cs.DTOs.Recompensa;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Recompensa;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class RecompensaService(IRecompensaRepository recompensaRepository) : IRecompensaService
{
    public async Task<List<Recompensa>> GetAllRecompensasAsync()
    {
        return await recompensaRepository.GetAllRecompensasAsync();
    }

    public async Task<Recompensa?> GetRecompensaByIdAsync(int id)
    {
        return await recompensaRepository.GetRecompensaByIdAsync(id);
    }

    public async Task<Recompensa> CreateRecompensaAsync(CreateRecompensaDto createRecompensaDto)
    {
        var recompensa = createRecompensaDto.ToRecompensaFromCreate();
        await recompensaRepository.CreateRecompensaAsync(recompensa);
        return recompensa;
    }

    public async Task<Recompensa?> UpdateRecompensaByAsync(int id, UpdateRecompensaDto updateRecompensaDto)
    {
        return await recompensaRepository.UpdateRecompensaByAsync(id, updateRecompensaDto);
    }

    public async Task<bool> DeleteRecompensaByAsync(int id)
    {
        var recompensa = await recompensaRepository.DeleteRecompensaByAsync(id);
        return recompensa != null;
    }
}