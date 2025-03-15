using odontoprev_api_cs.DTOs.Recompensa;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IRecompensaRepository
{
    Task<List<Recompensa>> GetAllRecompensasAsync();
    Task<Recompensa?> GetRecompensaByIdAsync(int id);
    Task<Recompensa> CreateRecompensaAsync(CreateRecompensaDto recompensa);
    Task<Recompensa?> UpdateRecompensaByAsync(int id, UpdateRecompensaDto recompensa);
    Task<Recompensa?> DeleteRecompensaByAsync(int id);
}