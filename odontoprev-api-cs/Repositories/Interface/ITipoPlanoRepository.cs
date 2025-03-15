using odontoprev_api_cs.DTOs.TipoPlano;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface ITipoPlanoRepository
{
    Task<List<TipoPlano>> GetAllTipoPlanosAsync();
    Task<TipoPlano?> GetTipoPlanoByIdAsync(int id);
    Task<TipoPlano> CreateTipoPlanoAsync(CreateTipoPlanoDto tipoPlano);
    Task<TipoPlano?> UpdateTipoPlanoByAsync(int id, UpdateTipoPlanoDto tipoPlano);
    Task<TipoPlano?> DeleteTipoPlanoByAsync(int id);
}