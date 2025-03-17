using odontoprev_api_cs.DTOs.TipoPlano;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoPlano;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class TipoPlanoService(ITipoPlanoRepository tipoPlanoRepository) : ITipoPlanoService
{
    public async Task<List<TipoPlano>> GetAllTipoPlanosAsync()
    {
        return await tipoPlanoRepository.GetAllTipoPlanosAsync();
    }

    public async Task<TipoPlano?> GetTipoPlanoByIdAsync(int id)
    {
        return await tipoPlanoRepository.GetTipoPlanoByIdAsync(id);
    }

    public async Task<TipoPlano> CreateTipoPlanoAsync(CreateTipoPlanoDto createTipoPlanoDto)
    {
        var tipoPlano = createTipoPlanoDto.ToTipoPlanoFromCreate();
        await tipoPlanoRepository.CreateTipoPlanoAsync(tipoPlano);
        return tipoPlano;
    }

    public async Task<TipoPlano?> UpdateTipoPlanoByAsync(int id, UpdateTipoPlanoDto updateTipoPlanoDto)
    {
        return await tipoPlanoRepository.UpdateTipoPlanoByAsync(id, updateTipoPlanoDto);
    }

    public async Task<bool> DeleteTipoPlanoByAsync(int id)
    {
        var tipoPlano = await tipoPlanoRepository.DeleteTipoPlanoByAsync(id);
        return tipoPlano != null;
    }
}