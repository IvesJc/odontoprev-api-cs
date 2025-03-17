using odontoprev_api_cs.DTOs.Plano;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IPlanoService
{
    Task<List<Plano>> GetAllPlanosAsync();
    Task<Plano?> GetPlanoByIdAsync(int id);
    Task<Plano> CreatePlanoAsync(CreatePlanoDto createPlanoDto);
    Task<Plano?> UpdatePlanoByAsync(int id, UpdatePlanoDto updatePlanoDto);
    Task<bool> DeletePlanoByAsync(int id);
}
