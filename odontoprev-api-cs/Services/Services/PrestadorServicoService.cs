using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.PrestadorServico;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class PrestadorServicoService(IPrestadorServicoRepository prestadorServicoRepository) : IPrestadorServicoService
{
    public async Task<List<PrestadorServico>> GetAllPrestadorServicosAsync()
    {
        return await prestadorServicoRepository.GetAllPrestadorServicosAsync();
    }

    public async Task<PrestadorServico?> GetPrestadorServicoByIdAsync(int id)
    {
        return await prestadorServicoRepository.GetPrestadorServicoByIdAsync(id);
    }

    public async Task<PrestadorServico> CreatePrestadorServicoAsync(CreatePrestadorServicoDto createPrestadorServicoDto)
    {
        var prestadorServico = createPrestadorServicoDto.ToPrestadorServicoFromCreate();
        await prestadorServicoRepository.CreatePrestadorServicoAsync(prestadorServico);
        return prestadorServico;
    }

    public async Task<PrestadorServico?> UpdatePrestadorServicoByAsync(int id, UpdatePrestadorServicoDto updatePrestadorServicoDto)
    {
        return await prestadorServicoRepository.UpdatePrestadorServicoByAsync(id, updatePrestadorServicoDto);
    }

    public async Task<bool> DeletePrestadorServicoByAsync(int id)
    {
        var prestadorServico = await prestadorServicoRepository.DeletePrestadorServicoByAsync(id);
        return prestadorServico != null;
    }
}