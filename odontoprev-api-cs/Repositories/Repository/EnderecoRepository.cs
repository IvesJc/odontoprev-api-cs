using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class EnderecoRepository(AppDbContext dbContext) : IEnderecoRepository
{
    public Task<List<Endereco>> GetAllEnderecosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Endereco?> GetEnderecoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Endereco> CreateEnderecoAsync(Endereco endereco)
    {
        throw new NotImplementedException();
    }

    public Task<Endereco?> UpdateEnderecoByAsync(int id, Endereco endereco)
    {
        throw new NotImplementedException();
    }

    public Task<Endereco?> DeleteEnderecoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}