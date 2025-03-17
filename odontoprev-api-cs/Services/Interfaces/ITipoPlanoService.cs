using odontoprev_api_cs.DTOs.TipoPlano;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface ITipoPlanoService
{
    Task<List<TipoPlano>> GetAllTipoPlanosAsync();
    Task<TipoPlano?> GetTipoPlanoByIdAsync(int id);
    Task<TipoPlano> CreateTipoPlanoAsync(CreateTipoPlanoDto createTipoPlanoDto);
    Task<TipoPlano?> UpdateTipoPlanoByAsync(int id, UpdateTipoPlanoDto updateTipoPlanoDto);
    Task<bool> DeleteTipoPlanoByAsync(int id);
}
