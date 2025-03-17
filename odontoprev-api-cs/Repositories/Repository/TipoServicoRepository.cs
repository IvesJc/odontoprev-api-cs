using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.TipoServico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.TipoServico;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class TipoServicoRepository(AppDbContext dbContext) :  ITipoServicoRepository
{
    public async Task<List<TipoServico>> GetAllTipoServicosAsync()
    {
        return await dbContext.TipoServico.ToListAsync();
    }

    public async Task<TipoServico?> GetTipoServicoByIdAsync(int id)
    {
        return await dbContext.TipoServico.FindAsync(id);
    }

    public async Task<TipoServico> CreateTipoServicoAsync(TipoServico tipoServico)
    {
        await dbContext.AddAsync(tipoServico);
        await dbContext.SaveChangesAsync();
        return tipoServico;
    }

    public async Task<TipoServico?> UpdateTipoServicoByAsync(int id, UpdateTipoServicoDto updateTipoServicoDto)
    {
        var tipoServico = await dbContext.TipoServico.FirstOrDefaultAsync(ts => ts.Id == id);
        if (tipoServico == null)
        {
            return null;
        }
        
        tipoServico.Nome = updateTipoServicoDto.Nome;
        tipoServico.ValorReais = updateTipoServicoDto.ValorReais;
        await dbContext.SaveChangesAsync();
        return tipoServico;
    }

    public async Task<TipoServico?> DeleteTipoServicoByAsync(int id)
    {
        var tipoServico = await dbContext.TipoServico.FirstOrDefaultAsync(ts => ts.Id == id);
        if (tipoServico == null)
        {
            return null;
        } 
        dbContext.Remove(tipoServico);
        await dbContext.SaveChangesAsync();
        return tipoServico;
    }
}