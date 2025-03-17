using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Servico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Servico;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class ServicoRepository(AppDbContext dbContext) :  IServicoRepository
{
    public async Task<List<Servico>> GetAllServicosAsync()
    {
        return await dbContext.Servico.ToListAsync();
    }

    public async Task<Servico?> GetServicoByIdAsync(int id)
    {
        return await dbContext.Servico.FindAsync(id);
    }

    public async Task<Servico> CreateServicoAsync(Servico servico)
    {
        await dbContext.AddAsync(servico);
        await dbContext.SaveChangesAsync();
        return servico;
    }

    public async Task<Servico?> UpdateServicoByAsync(int id, UpdateServicoDto updateServicoDto)
    {
        var servico = await dbContext.Servico.FirstOrDefaultAsync(s => s.Id == id);
        if (servico == null)
        {
            return null;
        }
        
        servico.TipoServicoId = updateServicoDto.TipoServicoId;
        servico.SinistroId = updateServicoDto.SinistroId;
        servico.ValorPago = updateServicoDto.ValorPago;
        
        await dbContext.SaveChangesAsync();
        return servico;
    }

    public async Task<Servico?> DeleteServicoByAsync(int id)
    {
        var servico = await dbContext.Servico.FirstOrDefaultAsync(s => s.Id == id);
        if (servico == null)
        {
            return null;
        }

        dbContext.Servico.Remove(servico);
        await dbContext.SaveChangesAsync();
        return servico;
    }
}