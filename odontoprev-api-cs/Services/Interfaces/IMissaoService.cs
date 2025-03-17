using odontoprev_api_cs.DTOs.Missao;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IMissaoService
{
    Task<List<Missao>> GetAllMissaosAsync();
    Task<Missao?> GetMissaoByIdAsync(int id);
    Task<Missao> CreateMissaoAsync(CreateMissaoDto createMissaoDto);
    Task<Missao?> UpdateMissaoByAsync(int id, UpdateMissaoDto updateMissaoDto);
    Task<bool> DeleteMissaoByAsync(int id);
}
