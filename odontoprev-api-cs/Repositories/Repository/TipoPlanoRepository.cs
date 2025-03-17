using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.TipoPlano;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoPlano;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoPlanoRepository(AppDbContext dbContext) : ITipoPlanoRepository
{
    public async Task<List<TipoPlano>> GetAllTipoPlanosAsync()
    {
        return await dbContext.TipoPlano.ToListAsync();
    }

    public async Task<TipoPlano?> GetTipoPlanoByIdAsync(int id)
    {
        return await dbContext.TipoPlano.FindAsync(id);
    }

    public async Task<TipoPlano> CreateTipoPlanoAsync(TipoPlano tipoPlano)
    {
        await dbContext.AddAsync(tipoPlano);
        await dbContext.SaveChangesAsync();
        return tipoPlano;
    }

    public async Task<TipoPlano?> UpdateTipoPlanoByAsync(int id, UpdateTipoPlanoDto updateTipoPlano)
    {
        var tipoPlano = await dbContext.TipoPlano.FirstOrDefaultAsync(tp => tp.Id == id);
        if (tipoPlano == null)
        {
            return null;
        }
        
        tipoPlano.Tipo = (TipoEnum)updateTipoPlano.Tipo;
        tipoPlano.Nome = updateTipoPlano.Nome;
        tipoPlano.Preco = updateTipoPlano.Preco;
        tipoPlano.CarenciaDias = updateTipoPlano.CarenciaDias;
        tipoPlano.ValidadeDias = updateTipoPlano.ValidadeDias;
        
        await dbContext.SaveChangesAsync();
        return tipoPlano;
    }

    public async Task<TipoPlano?> DeleteTipoPlanoByAsync(int id)
    {
        var tipoPlano = await dbContext.TipoPlano.FirstOrDefaultAsync(tp => tp.Id == id);
        if (tipoPlano == null)
        {
            return null;
        }
        
        dbContext.TipoPlano.Remove(tipoPlano);
        await dbContext.SaveChangesAsync();
        return tipoPlano;
    }
}