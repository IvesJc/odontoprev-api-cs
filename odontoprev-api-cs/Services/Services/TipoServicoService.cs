using odontoprev_api_cs.DTOs.TipoServico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoServico;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class TipoServicoService(ITipoServicoRepository tipoServicoRepository) : ITipoServicoService
{
    public async Task<List<TipoServico>> GetAllTipoServicosAsync()
    {
        return await tipoServicoRepository.GetAllTipoServicosAsync();
    }

    public async Task<TipoServico?> GetTipoServicoByIdAsync(int id)
    {
        return await tipoServicoRepository.GetTipoServicoByIdAsync(id);
    }

    public async Task<TipoServico> CreateTipoServicoAsync(CreateTipoServicoDto createTipoServicoDto)
    {
        var tipoServico = createTipoServicoDto.ToTipoServicoFromCreate();
        await tipoServicoRepository.CreateTipoServicoAsync(tipoServico);
        return tipoServico;
    }

    public async Task<TipoServico?> UpdateTipoServicoByAsync(int id, UpdateTipoServicoDto updateTipoServicoDto)
    {
        return await tipoServicoRepository.UpdateTipoServicoByAsync(id, updateTipoServicoDto);
    }

    public async Task<bool> DeleteTipoServicoByAsync(int id)
    {
        var tipoServico = await tipoServicoRepository.DeleteTipoServicoByAsync(id);
        return tipoServico != null;
    }
}