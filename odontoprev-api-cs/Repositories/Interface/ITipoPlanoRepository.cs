using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface ITipoPlanoRepository
{
    Task<List<TipoPlano>> GetAllTipoPlanosAsync();
    Task<TipoPlano?> GetTipoPlanoByIdAsync(int id);
    Task<TipoPlano> CreateTipoPlanoAsync(TipoPlano tipoPlano);
    Task<TipoPlano?> UpdateTipoPlanoByAsync(int id, TipoPlano tipoPlano);
    Task<TipoPlano?> DeleteTipoPlanoByAsync(int id);
}