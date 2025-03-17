using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Recompensa;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Recompensa;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class RecompensaRepository(AppDbContext dbContext) : IRecompensaRepository
{
    public async Task<List<Recompensa>> GetAllRecompensasAsync()
    {
        return await dbContext.Recompensa.ToListAsync();
    }

    public async Task<Recompensa?> GetRecompensaByIdAsync(int id)
    {
        return await dbContext.Recompensa.FindAsync(id);
    }

    public async Task<Recompensa> CreateRecompensaAsync(Recompensa recompensa)
    {
        await dbContext.AddAsync(recompensa);
        await dbContext.SaveChangesAsync();
        return recompensa;
    }

    public async Task<Recompensa?> UpdateRecompensaByAsync(int id, UpdateRecompensaDto updateRecompensaDto)
    {
        var recompensa = await dbContext.Recompensa.FirstOrDefaultAsync(r => r.Id == id);
        if (recompensa == null)
        {
            return null;
        }

        recompensa.TipoRecompensaId = updateRecompensaDto.TipoRecompensaId;
        recompensa.BeneficiarioId = updateRecompensaDto.BeneficiarioId;
        recompensa.ExpiraEm = updateRecompensaDto.ExpiraEm;
        recompensa.ResgatadoEm = updateRecompensaDto.ResgatadoEm;

        await dbContext.SaveChangesAsync();
        return recompensa;
    }

    public async Task<Recompensa?> DeleteRecompensaByAsync(int id)
    {
        var recompensa = await dbContext.Recompensa.FirstOrDefaultAsync(r => r.Id == id);
        if (recompensa == null)
        {
            return null;
        }

        dbContext.Recompensa.Remove(recompensa);
        await dbContext.SaveChangesAsync();
        return recompensa;
    }
}