using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.TipoMissao;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoMissao;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoMissaoRepository(AppDbContext dbContext) : ITipoMissaoRepository
{
    public async Task<List<TipoMissao>> GetAllTipoMissaosAsync()
    {
        return await dbContext.TipoMissao.ToListAsync();
    }

    public async Task<TipoMissao?> GetTipoMissaoByIdAsync(int id)
    {
        return await dbContext.TipoMissao.FindAsync(id);
    }

    public async Task<TipoMissao> CreateTipoMissaoAsync(TipoMissao tipoMissao)
    {
        await dbContext.AddAsync(tipoMissao);
        await dbContext.SaveChangesAsync();
        return tipoMissao;
    }

    public async Task<TipoMissao?> UpdateTipoMissaoByAsync(int id, UpdateTipoMissaoDto updateTipoMissao)
    {
        var tipoMissao = await dbContext.TipoMissao.FirstOrDefaultAsync(tm => tm.Id == id);
        if (tipoMissao == null)
        {
            return null;
        }
        
        tipoMissao.Frequencia = (FrequenciaEnum)updateTipoMissao.Frequencia;
        tipoMissao.Titulo = updateTipoMissao.Titulo;
        tipoMissao.RecompensaPadrao = updateTipoMissao.RecompensaPadrao;
        tipoMissao.DuracaoPadraoDias = updateTipoMissao.DuracaoPadraoDias;

        await dbContext.SaveChangesAsync();
        return tipoMissao;
    }

    public async Task<TipoMissao?> DeleteTipoMissaoByAsync(int id)
    {
        var tipoMissao = await dbContext.TipoMissao.FirstOrDefaultAsync(tm => tm.Id == id);
        if (tipoMissao == null)
        {
            return null;
        }
        
        dbContext.Remove(tipoMissao);
        await dbContext.SaveChangesAsync();
        return tipoMissao;
    }
}