using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoRecompensa;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoRecompensaRepository(AppDbContext dbContext) : ITipoRecompensaRepository
{
    public async Task<List<TipoRecompensa>> GetAllTipoRecompensasAsync()
    {
        return await dbContext.TipoRecompensa.ToListAsync();
    }

    public async Task<TipoRecompensa?> GetTipoRecompensaByIdAsync(int id)
    {
        return await dbContext.TipoRecompensa.FindAsync(id);
    }

    public async Task<TipoRecompensa> CreateTipoRecompensaAsync(TipoRecompensa tipoRecompensa)
    {
        await dbContext.AddAsync(tipoRecompensa);
        await dbContext.SaveChangesAsync();
        return tipoRecompensa;
    }

    public async Task<TipoRecompensa?> UpdateTipoRecompensaByAsync(int id, UpdateTipoRecompensaDto updateTipoRecompensa)
    {
        var tipoRecompensa = await dbContext.TipoRecompensa.FirstOrDefaultAsync(tr => tr.Id == id);
        if (tipoRecompensa == null)
        {
            return null;
        }
        
        tipoRecompensa.Aplicacao = (AplicacaoEnum)updateTipoRecompensa.Aplicacao;
        tipoRecompensa.Nome = updateTipoRecompensa.Nome;
        tipoRecompensa.ExpiracaoDias = updateTipoRecompensa.ExpiracaoDias;
        
        await dbContext.SaveChangesAsync();
        return tipoRecompensa;
    }

    public async Task<TipoRecompensa?> DeleteTipoRecompensaByAsync(int id)
    {
        var tipoRecompensa = await dbContext.TipoRecompensa.FirstOrDefaultAsync(tr => tr.Id == id);
        if (tipoRecompensa == null)
        {
            return null;
        }
        
        dbContext.Remove(tipoRecompensa);
        await dbContext.SaveChangesAsync();
        return tipoRecompensa;
    }
}