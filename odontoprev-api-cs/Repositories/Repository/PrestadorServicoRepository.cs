using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.PrestadorServico;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class PrestadorServicoRepository(AppDbContext dbContext) : IPrestadorServicoRepository
{
    public async Task<List<PrestadorServico>> GetAllPrestadorServicosAsync()
    {
        return await dbContext.PrestadorServico.ToListAsync();
    }

    public async Task<PrestadorServico?> GetPrestadorServicoByIdAsync(int id)
    {
        return await dbContext.PrestadorServico.FindAsync(id);
    }

    public async Task<PrestadorServico> CreatePrestadorServicoAsync(PrestadorServico prestadorServico)
    {
        await dbContext.AddAsync(prestadorServico);
        await dbContext.SaveChangesAsync();
        return prestadorServico;
    }

    public async Task<PrestadorServico?> UpdatePrestadorServicoByAsync(int id, UpdatePrestadorServicoDto updatePrestadorServico)
    {
        var prestadorServico = await dbContext.PrestadorServico.FirstOrDefaultAsync(ps => ps.Id == id);
        if (prestadorServico == null)
        {
            return null;
        }
        
        prestadorServico.Nome = updatePrestadorServico.Nome;
        prestadorServico.Avaliacao = updatePrestadorServico.Avaliacao;
        prestadorServico.Especialidade = (EspecialidadeEnum)updatePrestadorServico.Especialidade;
        prestadorServico.NumeroContrato = updatePrestadorServico.NumeroContrato;
        prestadorServico.NumeroCro = updatePrestadorServico.NumeroCro;
        prestadorServico.RedeCredenciadaId = updatePrestadorServico.RedeCredenciadaId;
        
        await dbContext.SaveChangesAsync();
        return prestadorServico;
    }

    public async Task<PrestadorServico?> DeletePrestadorServicoByAsync(int id)
    {
        var prestadorServico = await dbContext.PrestadorServico.FirstOrDefaultAsync(ps => ps.Id == id);
        if (prestadorServico == null)
        {
            return null;
        }
        
        dbContext.PrestadorServico.Remove(prestadorServico);
        await dbContext.SaveChangesAsync();
        return prestadorServico;
    }
}