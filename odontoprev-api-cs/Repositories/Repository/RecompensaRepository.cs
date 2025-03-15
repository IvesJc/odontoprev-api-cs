using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class RecompensaRepository(AppDbContext dbContext) : IRecompensaRepository
{
    public Task<List<Recompensa>> GetAllRecompensasAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Recompensa?> GetRecompensaByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Recompensa> CreateRecompensaAsync(Recompensa recompensa)
    {
        throw new NotImplementedException();
    }

    public Task<Recompensa?> UpdateRecompensaByAsync(int id, Recompensa recompensa)
    {
        throw new NotImplementedException();
    }

    public Task<Recompensa?> DeleteRecompensaByAsync(int id)
    {
        throw new NotImplementedException();
    }
}