using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.TipoServico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoServicoRepository(AppDbContext dbContext) :  ITipoServicoRepository
{
    public Task<List<TipoServico>> GetAllTipoServicosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TipoServico?> GetTipoServicoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TipoServico> CreateTipoServicoAsync(CreateTipoServicoDto tipoServico)
    {
        throw new NotImplementedException();
    }

    public Task<TipoServico?> UpdateTipoServicoByAsync(int id, UpdateTipoServicoDto tipoServico)
    {
        throw new NotImplementedException();
    }

    public Task<TipoServico?> DeleteTipoServicoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}