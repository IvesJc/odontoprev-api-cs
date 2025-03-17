using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Beneficiario;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Beneficiario;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class BeneficiarioRepository(AppDbContext dbContext) : IBeneficiarioRepository
{
    public async Task<List<Beneficiario>> GetAllBeneficiariosAsync()
    {
        return await dbContext.Beneficiario.ToListAsync();
    }

    public async Task<Beneficiario?> GetBeneficiarioByIdAsync(int id)
    {
        return await dbContext.Beneficiario.FindAsync(id);
    }

    public async Task<Beneficiario> CreateBeneficiarioAsync(Beneficiario beneficiario)
    {
        await dbContext.AddAsync(beneficiario);
        await dbContext.SaveChangesAsync();
        return beneficiario;
    }

    public async Task<Beneficiario?> UpdateBeneficiarioByAsync(int id, UpdateBeneficiarioDto updateBeneficiarioDto)
    {
        var beneficiario =  await dbContext.Beneficiario.FirstOrDefaultAsync(b => b.Id == id);
        if (beneficiario == null)
        {
            return null;
        }

        beneficiario.Nome = updateBeneficiarioDto.Nome;
        beneficiario.Cpf = updateBeneficiarioDto.Cpf;
        beneficiario.Tipo = (TipoBeneficiarioEnum)updateBeneficiarioDto.Tipo;
        beneficiario.Password = updateBeneficiarioDto.Password;
        beneficiario.Telefone = updateBeneficiarioDto.Telefone;
        beneficiario.DataAdesao = updateBeneficiarioDto.DataAdesao;
        beneficiario.FotoUrl = updateBeneficiarioDto.FotoUrl;
        beneficiario.NumeroContrato = updateBeneficiarioDto.NumeroContrato;
        beneficiario.EnderecoId = updateBeneficiarioDto.EnderecoId;
        beneficiario.EmpresaContratanteId = updateBeneficiarioDto.EmpresaContratanteId;
        
        await dbContext.SaveChangesAsync();
        return beneficiario;
    }

    public async Task<Beneficiario?> DeleteBeneficiarioByAsync(int id)
    {
        var beneficiario =  await dbContext.Beneficiario.FirstOrDefaultAsync(b => b.Id == id);
        if (beneficiario == null)
        {
            return null;
        }

        dbContext.Remove(id);
        await dbContext.SaveChangesAsync();
        return beneficiario;
    }
}