using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class MissaoRepository(AppDbContext dbContext) : IMissaoRepository
{
    public Task<List<Missao>> GetAllMissaosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Missao?> GetMissaoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Missao> CreateMissaoAsync(Missao missao)
    {
        throw new NotImplementedException();
    }

    public Task<Missao?> UpdateMissaoByAsync(int id, Missao missao)
    {
        throw new NotImplementedException();
    }

    public Task<Missao?> DeleteMissaoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}