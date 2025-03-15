using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IEnderecoRepository
{
    Task<List<Endereco>> GetAllEnderecosAsync();
    Task<Endereco?> GetEnderecoByIdAsync(int id);
    Task<Endereco> CreateEnderecoAsync(Endereco endereco);
    Task<Endereco?> UpdateEnderecoByAsync(int id, Endereco endereco);
    Task<Endereco?> DeleteEnderecoByAsync(int id);
}