using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.RedeCredenciada;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.RedeCredenciada;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class RedeCredenciadaRepository(AppDbContext dbContext) :  IRedeCredenciadaRepository
{
    public async Task<List<RedeCredenciada>> GetAllRedeCredenciadasAsync()
    {
        return await dbContext.RedeCredenciada.ToListAsync();
    }

    public async Task<RedeCredenciada?> GetRedeCredenciadaByIdAsync(int id)
    {
        return await dbContext.RedeCredenciada.FindAsync(id);
    }

    public async Task<RedeCredenciada> CreateRedeCredenciadaAsync(RedeCredenciada redeCredenciada)
    {
        await dbContext.AddAsync(redeCredenciada);
        await dbContext.SaveChangesAsync();
        return redeCredenciada;
    }

    public async Task<RedeCredenciada?> UpdateRedeCredenciadaByAsync(int id, UpdateRedeCredenciadaDto updateRedeCredenciada)
    {
        var redeCredenciada = await dbContext.RedeCredenciada.FirstOrDefaultAsync(rc => rc.Id == id);
        if (redeCredenciada == null)
        {
            return null;
        }
        
        redeCredenciada.Nome = updateRedeCredenciada.Nome;
        await dbContext.SaveChangesAsync();
        return redeCredenciada;
    }

    public async Task<RedeCredenciada?> DeleteRedeCredenciadaByAsync(int id)
    {
        var redeCredenciada = await dbContext.RedeCredenciada.FirstOrDefaultAsync(rc => rc.Id == id);
        if (redeCredenciada == null)
        {
            return null;
        }

        dbContext.RedeCredenciada.Remove(redeCredenciada);
        await dbContext.SaveChangesAsync();
        return redeCredenciada;
    }
}