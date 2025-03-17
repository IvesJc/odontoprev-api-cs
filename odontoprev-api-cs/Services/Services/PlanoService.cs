using odontoprev_api_cs.DTOs.Plano;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Plano;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class PlanoService(IPlanoRepository planoRepository) : IPlanoService
{
    public async Task<List<Plano>> GetAllPlanosAsync()
    {
        return await planoRepository.GetAllPlanosAsync();
    }

    public async Task<Plano?> GetPlanoByIdAsync(int id)
    {
        return await planoRepository.GetPlanoByIdAsync(id);
    }

    public async Task<Plano> CreatePlanoAsync(CreatePlanoDto createPlanoDto)
    {
        var plano = createPlanoDto.ToPlanoFromCreate();
        await planoRepository.CreatePlanoAsync(plano);
        return plano;
    }

    public async Task<Plano?> UpdatePlanoByAsync(int id, UpdatePlanoDto updatePlanoDto)
    {
        return await planoRepository.UpdatePlanoByAsync(id, updatePlanoDto);
    }

    public async Task<bool> DeletePlanoByAsync(int id)
    {
        var plano = await planoRepository.DeletePlanoByAsync(id);
        return plano != null;
    }
}