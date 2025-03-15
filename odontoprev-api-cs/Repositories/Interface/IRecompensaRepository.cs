using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IRecompensaRepository
{
    Task<List<Recompensa>> GetAllRecompensasAsync();
    Task<Recompensa?> GetRecompensaByIdAsync(int id);
    Task<Recompensa> CreateRecompensaAsync(Recompensa recompensa);
    Task<Recompensa?> UpdateRecompensaByAsync(int id, Recompensa recompensa);
    Task<Recompensa?> DeleteRecompensaByAsync(int id);
}