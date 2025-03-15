using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Sinistro;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class SinistroRepository(AppDbContext dbContext) : ISinistroRepository
{
    public Task<List<Sinistro>> GetAllSinistrosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Sinistro?> GetSinistroByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Sinistro> CreateSinistroAsync(CreateSinistroDto sinistro)
    {
        throw new NotImplementedException();
    }

    public Task<Sinistro?> UpdateSinistroByAsync(int id, UpdateSinistroDto sinistro)
    {
        throw new NotImplementedException();
    }

    public Task<Sinistro?> DeleteSinistroByAsync(int id)
    {
        throw new NotImplementedException();
    }
}