using odontoprev_api_cs.DTOs.Servico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Servico;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class ServicoService(IServicoRepository servicoRepository) : IServicoService
{
    public async Task<List<Servico>> GetAllServicosAsync()
    {
        return await servicoRepository.GetAllServicosAsync();
    }

    public async Task<Servico?> GetServicoByIdAsync(int id)
    {
        return await servicoRepository.GetServicoByIdAsync(id);
    }

    public async Task<Servico> CreateServicoAsync(CreateServicoDto createServicoDto)
    {
        var servico = createServicoDto.ToServicoFromCreate();
        await servicoRepository.CreateServicoAsync(servico);
        return servico;
    }

    public async Task<Servico?> UpdateServicoByAsync(int id, UpdateServicoDto updateServicoDto)
    {
        return await servicoRepository.UpdateServicoByAsync(id, updateServicoDto);
    }

    public async Task<bool> DeleteServicoByAsync(int id)
    {
        var servico = await servicoRepository.DeleteServicoByAsync(id);
        return servico != null;
    }
}