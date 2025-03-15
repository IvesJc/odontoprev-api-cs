using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoPlanoRepository(AppDbContext dbContext) : ITipoPlanoRepository
{
    public Task<List<TipoPlano>> GetAllTipoPlanosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TipoPlano?> GetTipoPlanoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TipoPlano> CreateTipoPlanoAsync(TipoPlano tipoPlano)
    {
        throw new NotImplementedException();
    }

    public Task<TipoPlano?> UpdateTipoPlanoByAsync(int id, TipoPlano tipoPlano)
    {
        throw new NotImplementedException();
    }

    public Task<TipoPlano?> DeleteTipoPlanoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}