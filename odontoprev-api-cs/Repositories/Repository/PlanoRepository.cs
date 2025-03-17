using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Plano;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Plano;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class PlanoRepository(AppDbContext dbContext) : IPlanoRepository
{
    public async Task<List<Plano>> GetAllPlanosAsync()
    {
        return await dbContext.Plano.ToListAsync()
            ;
    }

    public async Task<Plano?> GetPlanoByIdAsync(int id)
    {
        return await dbContext.Plano.FindAsync(id);
    }

    public async Task<Plano> CreatePlanoAsync(Plano plano)
    {
        await dbContext.AddAsync(plano);
        await dbContext.SaveChangesAsync();
        return plano;
    }

    public async Task<Plano?> UpdatePlanoByAsync(int id, UpdatePlanoDto updatePlano)
    {
        var plano = await dbContext.Plano.FirstOrDefaultAsync(pl => pl.Id == id);
        if (plano == null)
        {
            return null;
        }

        plano.TipoPlanoId = updatePlano.TipoPlanoId;
        plano.DataExpiracao = updatePlano.DataExpiracao;
        plano.PrecoCobrado = updatePlano.PrecoCobrado;
        plano.DataFinalCarencia = updatePlano.DataFinalCarencia;
        plano.EmpresaContratanteId = updatePlano.EmpresaContratanteId;

        await dbContext.SaveChangesAsync();
        return plano;
    }

    public async Task<Plano?> DeletePlanoByAsync(int id)
    {
        var plano = await dbContext.Plano.FirstOrDefaultAsync(pl => pl.Id == id);
        if (plano == null)
        {
            return null;
        }

        dbContext.Plano.Remove(plano);
        await dbContext.SaveChangesAsync();
        return plano;
    }
}