using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IPlanoRepository
{
    Task<List<Plano>> GetAllPlanosAsync();
    Task<Plano?> GetPlanoByIdAsync(int id);
    Task<Plano> CreatePlanoAsync(Plano plano);
    Task<Plano?> UpdatePlanoByAsync(int id, Plano plano);
    Task<Plano?> DeletePlanoByAsync(int id);
}