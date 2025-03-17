using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoRecompensa;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class TipoRecompensaService(ITipoRecompensaRepository tipoRecompensaRepository) : ITipoRecompensaService
{
    public async Task<List<TipoRecompensa>> GetAllTipoRecompensasAsync()
    {
        return await tipoRecompensaRepository.GetAllTipoRecompensasAsync();
    }

    public async Task<TipoRecompensa?> GetTipoRecompensaByIdAsync(int id)
    {
        return await tipoRecompensaRepository.GetTipoRecompensaByIdAsync(id);
    }

    public async Task<TipoRecompensa> CreateTipoRecompensaAsync(CreateTipoRecompensaDto createTipoRecompensaDto)
    {
        var tipoRecompensa = createTipoRecompensaDto.ToTipoRecompensaFromCreate();
        await tipoRecompensaRepository.CreateTipoRecompensaAsync(tipoRecompensa);
        return tipoRecompensa;
    }

    public async Task<TipoRecompensa?> UpdateTipoRecompensaByAsync(int id, UpdateTipoRecompensaDto updateTipoRecompensaDto)
    {
        return await tipoRecompensaRepository.UpdateTipoRecompensaByAsync(id, updateTipoRecompensaDto);
    }

    public async Task<bool> DeleteTipoRecompensaByAsync(int id)
    {
        var tipoRecompensa = await tipoRecompensaRepository.DeleteTipoRecompensaByAsync(id);
        return tipoRecompensa != null;
    }
}