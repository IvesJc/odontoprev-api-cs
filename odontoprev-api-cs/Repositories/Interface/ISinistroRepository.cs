using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface ISinistroRepository
{
    Task<List<Sinistro>> GetAllSinistrosAsync();
    Task<Sinistro?> GetSinistroByIdAsync(int id);
    Task<Sinistro> CreateSinistroAsync(Sinistro sinistro);
    Task<Sinistro?> UpdateSinistroByAsync(int id, Sinistro sinistro);
    Task<Sinistro?> DeleteSinistroByAsync(int id);
}