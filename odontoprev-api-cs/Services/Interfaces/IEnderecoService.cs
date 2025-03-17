using odontoprev_api_cs.DTOs.Endereco;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IEnderecoService
{
    Task<List<Endereco>> GetAllEnderecosAsync();
    Task<Endereco?> GetEnderecoByIdAsync(int id);
    Task<Endereco> CreateEnderecoAsync(CreateEnderecoDto createEnderecoDto);
    Task<Endereco?> UpdateEnderecoByAsync(int id, UpdateEnderecoDto updateEnderecoDto);
    Task<bool> DeleteEnderecoByAsync(int id);
}
