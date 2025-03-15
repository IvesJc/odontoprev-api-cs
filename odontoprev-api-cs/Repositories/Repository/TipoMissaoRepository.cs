using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.TipoMissao;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoMissaoRepository(AppDbContext dbContext) : ITipoMissaoRepository
{
    public Task<List<TipoMissao>> GetAllTipoMissaosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TipoMissao?> GetTipoMissaoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TipoMissao> CreateTipoMissaoAsync(CreateTipoMissaoDto tipoMissao)
    {
        throw new NotImplementedException();
    }

    public Task<TipoMissao?> UpdateTipoMissaoByAsync(int id, UpdateTipoMissaoDto tipoMissao)
    {
        throw new NotImplementedException();
    }

    public Task<TipoMissao?> DeleteTipoMissaoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}