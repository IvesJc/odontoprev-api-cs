using odontoprev_api_cs.DTOs.Sinistro;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface ISinistroService
{
    Task<List<Sinistro>> GetAllSinistrosAsync();
    Task<Sinistro?> GetSinistroByIdAsync(int id);
    Task<Sinistro> CreateSinistroAsync(CreateSinistroDto createSinistroDto);
    Task<Sinistro?> UpdateSinistroByAsync(int id, UpdateSinistroDto updateSinistroDto);
    Task<bool> DeleteSinistroByAsync(int id);
}
