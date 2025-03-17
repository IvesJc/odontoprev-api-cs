using odontoprev_api_cs.DTOs.Recompensa;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IRecompensaService
{
    Task<List<Recompensa>> GetAllRecompensasAsync();
    Task<Recompensa?> GetRecompensaByIdAsync(int id);
    Task<Recompensa> CreateRecompensaAsync(CreateRecompensaDto createRecompensaDto);
    Task<Recompensa?> UpdateRecompensaByAsync(int id, UpdateRecompensaDto updateRecompensaDto);
    Task<bool> DeleteRecompensaByAsync(int id);
}
