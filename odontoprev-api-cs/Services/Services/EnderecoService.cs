using odontoprev_api_cs.DTOs.Endereco;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Endereco;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class EnderecoService(IEnderecoRepository enderecoRepository) : IEnderecoService
{
    public async Task<List<Endereco>> GetAllEnderecosAsync()
    {
        return await enderecoRepository.GetAllEnderecosAsync();
    }

    public async Task<Endereco?> GetEnderecoByIdAsync(int id)
    {
        return await enderecoRepository.GetEnderecoByIdAsync(id);
    }

    public async Task<Endereco> CreateEnderecoAsync(CreateEnderecoDto createEnderecoDto)
    {
        var endereco = createEnderecoDto.ToEnderecoFromCreate();
        await enderecoRepository.CreateEnderecoAsync(endereco);
        return endereco;
    }

    public async Task<Endereco?> UpdateEnderecoByAsync(int id, UpdateEnderecoDto updateEnderecoDto)
    {
        return await enderecoRepository.UpdateEnderecoByAsync(id, updateEnderecoDto);
    }

    public async Task<bool> DeleteEnderecoByAsync(int id)
    {
        var endereco = await enderecoRepository.DeleteEnderecoByAsync(id);
        return endereco != null;
    }
}