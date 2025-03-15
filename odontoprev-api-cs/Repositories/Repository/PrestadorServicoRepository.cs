using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class PrestadorServicoRepository(AppDbContext dbContext) : IPrestadorServicoRepository
{
    public Task<List<PrestadorServico>> GetAllPrestadorServicosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PrestadorServico?> GetPrestadorServicoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PrestadorServico> CreatePrestadorServicoAsync(CreatePrestadorServicoDto prestadorServico)
    {
        throw new NotImplementedException();
    }

    public Task<PrestadorServico?> UpdatePrestadorServicoByAsync(int id, UpdatePrestadorServicoDto prestadorServico)
    {
        throw new NotImplementedException();
    }

    public Task<PrestadorServico?> DeletePrestadorServicoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}