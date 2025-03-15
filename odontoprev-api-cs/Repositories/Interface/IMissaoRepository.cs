using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IMissaoRepository
{
    Task<List<Missao>> GetAllMissaosAsync();
    Task<Missao?> GetMissaoByIdAsync(int id);
    Task<Missao> CreateMissaoAsync(Missao missao);
    Task<Missao?> UpdateMissaoByAsync(int id, Missao missao);
    Task<Missao?> DeleteMissaoByAsync(int id);
}