using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Servico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class ServicoRepository(AppDbContext dbContext) :  IServicoRepository
{
    public Task<List<Servico>> GetAllServicosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Servico?> GetServicoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Servico> CreateServicoAsync(CreateServicoDto servico)
    {
        throw new NotImplementedException();
    }

    public Task<Servico?> UpdateServicoByAsync(int id, UpdateServicoDto servico)
    {
        throw new NotImplementedException();
    }

    public Task<Servico?> DeleteServicoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}