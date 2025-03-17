using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.EmpresaContratante;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.EmpresaContratante;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class EmpresaContratanteRepository(AppDbContext dbContext) : IEmpresaContratanteRepository
{
    public async Task<List<EmpresaContratante>> GetAllEmpresaContratantesAsync()
    {
        return await dbContext.EmpresaContratante.ToListAsync();
    }

    public async Task<EmpresaContratante?> GetEmpresaContratanteByIdAsync(int id)
    {
        return await dbContext.EmpresaContratante.FindAsync(id);

    }

    public async Task<EmpresaContratante> CreateEmpresaContratanteAsync(EmpresaContratante empresaContratante)
    {
        await dbContext.AddAsync(empresaContratante);
        await dbContext.SaveChangesAsync();
        return empresaContratante;
    }

    public async Task<EmpresaContratante?> UpdateEmpresaContratanteByAsync(int id, UpdateEmpresaContratanteDto updateEmpresaContratante)
    {
        var empresaContratante = await dbContext.EmpresaContratante.FirstOrDefaultAsync(ec => ec.Id == id);
        if (empresaContratante == null)
        {
            return null;
        }
        
        empresaContratante.Nome = updateEmpresaContratante.Nome;
        empresaContratante.Cnpj = updateEmpresaContratante.Cnpj;
        empresaContratante.NumeroContrato = updateEmpresaContratante.NumeroContrato;

        await dbContext.SaveChangesAsync();
        return empresaContratante;
    }

    public async Task<EmpresaContratante?> DeleteEmpresaContratanteByAsync(int id)
    {
        var empresaContratante = await dbContext.EmpresaContratante.FirstOrDefaultAsync(ec => ec.Id == id);
        if (empresaContratante == null)
        {
            return null;
        }
        
        dbContext.EmpresaContratante.Remove(empresaContratante);
        await dbContext.SaveChangesAsync();
        return empresaContratante;
    }
}