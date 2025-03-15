using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoRecompensaRepository(AppDbContext dbContext) : ITipoRecompensaRepository
{
    public Task<List<TipoRecompensa>> GetAllTipoRecompensasAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TipoRecompensa?> GetTipoRecompensaByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TipoRecompensa> CreateTipoRecompensaAsync(CreateTipoRecompensaDto tipoRecompensa)
    {
        throw new NotImplementedException();
    }

    public Task<TipoRecompensa?> UpdateTipoRecompensaByAsync(int id, UpdateTipoRecompensaDto tipoRecompensa)
    {
        throw new NotImplementedException();
    }

    public Task<TipoRecompensa?> DeleteTipoRecompensaByAsync(int id)
    {
        throw new NotImplementedException();
    }
}