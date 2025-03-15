using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class RedeCredenciadaRepository(AppDbContext dbContext) :  IRedeCredenciadaRepository
{
    public Task<List<RedeCredenciada>> GetAllRedeCredenciadasAsync()
    {
        throw new NotImplementedException();
    }

    public Task<RedeCredenciada?> GetRedeCredenciadaByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<RedeCredenciada> CreateRedeCredenciadaAsync(RedeCredenciada redeCredenciada)
    {
        throw new NotImplementedException();
    }

    public Task<RedeCredenciada?> UpdateRedeCredenciadaByAsync(int id, RedeCredenciada redeCredenciada)
    {
        throw new NotImplementedException();
    }

    public Task<RedeCredenciada?> DeleteRedeCredenciadaByAsync(int id)
    {
        throw new NotImplementedException();
    }
}