using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface ITipoRecompensaService
{
    Task<List<TipoRecompensa>> GetAllTipoRecompensasAsync();
    Task<TipoRecompensa?> GetTipoRecompensaByIdAsync(int id);
    Task<TipoRecompensa> CreateTipoRecompensaAsync(CreateTipoRecompensaDto createTipoRecompensaDto);
    Task<TipoRecompensa?> UpdateTipoRecompensaByAsync(int id, UpdateTipoRecompensaDto updateTipoRecompensaDto);
    Task<bool> DeleteTipoRecompensaByAsync(int id);
}
