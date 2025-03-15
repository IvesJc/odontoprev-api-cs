using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface ITipoRecompensaRepository
{
    Task<List<TipoRecompensa>> GetAllTipoRecompensasAsync();
    Task<TipoRecompensa?> GetTipoRecompensaByIdAsync(int id);
    Task<TipoRecompensa> CreateTipoRecompensaAsync(TipoRecompensa tipoRecompensa);
    Task<TipoRecompensa?> UpdateTipoRecompensaByAsync(int id, TipoRecompensa tipoRecompensa);
    Task<TipoRecompensa?> DeleteTipoRecompensaByAsync(int id);
}