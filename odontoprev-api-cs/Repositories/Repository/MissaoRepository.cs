using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Missao;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Missao;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class MissaoRepository(AppDbContext dbContext) : IMissaoRepository
{
    public async Task<List<Missao>> GetAllMissaosAsync()
    {
        return await dbContext.Missao.ToListAsync();
    }

    public async Task<Missao?> GetMissaoByIdAsync(int id)
    {
        return await dbContext.Missao.FindAsync(id);
    }

    public async Task<Missao> CreateMissaoAsync(Missao missao)
    {
        await dbContext.AddAsync(missao);
        await dbContext.SaveChangesAsync();
        return missao;
    }

    public async Task<Missao?> UpdateMissaoByAsync(int id, UpdateMissaoDto updateMissaoDto)
    {
        var missao = await dbContext.Missao.FirstOrDefaultAsync(m => m.Id == id);
        if (missao == null)
        {
            return missao;
        }
        
        missao.TipoMissaoId = updateMissaoDto.TipoMissaoId;
        missao.Concluido = updateMissaoDto.Concluido;
        missao.BeneficiarioId = updateMissaoDto.BeneficiarioId;
        missao.ExpiraEm = updateMissaoDto.ExpiraEm;
        missao.RecompensaRecebida = updateMissaoDto.RecompensaRecebida;
        
        await dbContext.SaveChangesAsync();
        return missao;
    }

    public async Task<Missao?> DeleteMissaoByAsync(int id)
    {
        var missao = await dbContext.Missao.FirstOrDefaultAsync(m => m.Id == id);
        if (missao == null)
        {
            return missao;
        }
        
        dbContext.Missao.Remove(missao);
        await dbContext.SaveChangesAsync();
        return missao;
    }
}