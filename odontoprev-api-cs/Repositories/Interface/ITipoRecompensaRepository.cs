using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface ITipoRecompensaRepository
{
    Task<List<TipoRecompensa>> GetAllTipoRecompensasAsync();
    Task<TipoRecompensa?> GetTipoRecompensaByIdAsync(int id);
    Task<TipoRecompensa> CreateTipoRecompensaAsync(CreateTipoRecompensaDto tipoRecompensa);
    Task<TipoRecompensa?> UpdateTipoRecompensaByAsync(int id, UpdateTipoRecompensaDto tipoRecompensa);
    Task<TipoRecompensa?> DeleteTipoRecompensaByAsync(int id);
}