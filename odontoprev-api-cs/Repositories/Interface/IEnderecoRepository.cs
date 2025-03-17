using odontoprev_api_cs.DTOs.EmpresaContratante;
using odontoprev_api_cs.DTOs.Endereco;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IEnderecoRepository
{
    Task<List<Endereco>> GetAllEnderecosAsync();
    Task<Endereco?> GetEnderecoByIdAsync(int id);
    Task<Endereco> CreateEnderecoAsync(Endereco endereco);
    Task<Endereco?> UpdateEnderecoByAsync(int id, UpdateEnderecoDto endereco);
    Task<Endereco?> DeleteEnderecoByAsync(int id);
}