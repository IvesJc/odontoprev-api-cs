using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Sinistro;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Sinistro;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class SinistroRepository(AppDbContext dbContext) : ISinistroRepository
{
    public async Task<List<Sinistro>> GetAllSinistrosAsync()
    {
        return await dbContext.Sinistro.ToListAsync();
    }

    public async Task<Sinistro?> GetSinistroByIdAsync(int id)
    {
        return await dbContext.Sinistro.FindAsync(id);
    }

    public async Task<Sinistro> CreateSinistroAsync(Sinistro sinistro)
    {
        await dbContext.AddAsync(sinistro);
        await dbContext.SaveChangesAsync();
        return sinistro;
    }

    public async Task<Sinistro?> UpdateSinistroByAsync(int id, UpdateSinistroDto updateSinistroDto)
    {
        var sinistro = await dbContext.Sinistro.FirstOrDefaultAsync(s => s.Id == id);
        if (sinistro == null)
        {
            return null;
        }
        
        sinistro.BeneficiarioId = updateSinistroDto.BeneficiarioId;
        sinistro.DataAutorizacao = updateSinistroDto.DataAutorizacao;
        sinistro.DataSolicitacao = updateSinistroDto.DataSolicitacao;
        sinistro.PrestadorServicoId = updateSinistroDto.PrestadorServicoId;
        sinistro.ValorPagoParaPrestador = updateSinistroDto.ValorPagoParaPrestador;
        
        await dbContext.SaveChangesAsync();
        return sinistro;
    }

    public async Task<Sinistro?> DeleteSinistroByAsync(int id)
    {
        var sinistro = await dbContext.Sinistro.FirstOrDefaultAsync(s => s.Id == id);
        if (sinistro == null)
        {
            return null;
        }

        dbContext.Sinistro.Remove(sinistro);
        await dbContext.SaveChangesAsync();
        return sinistro;
    }
}