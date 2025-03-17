using odontoprev_api_cs.DTOs.Missao;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IMissaoRepository
{
    Task<List<Missao>> GetAllMissaosAsync();
    Task<Missao?> GetMissaoByIdAsync(int id);
    Task<Missao> CreateMissaoAsync(Missao missao);
    Task<Missao?> UpdateMissaoByAsync(int id, UpdateMissaoDto missao);
    Task<Missao?> DeleteMissaoByAsync(int id);
}