using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class ProgramaRelacionamentoStatusRepository(AppDbContext dbContext) :  IProgramaRelacionamentoStatusRepository
{
    public async Task<List<ProgramaRelacionamentoStatus>> GetAllProgramaRelacionamentoStatussAsync()
    {
        return await dbContext.ProgramaRelacionamentoStatus.ToListAsync();
    }

    public async Task<ProgramaRelacionamentoStatus?> GetProgramaRelacionamentoStatusByIdAsync(int id)
    {
        return await dbContext.ProgramaRelacionamentoStatus.FindAsync(id);
    }

    public async Task<ProgramaRelacionamentoStatus> CreateProgramaRelacionamentoStatusAsync(ProgramaRelacionamentoStatus programaRelacionamentoStatus)
    {
        await dbContext.AddAsync(programaRelacionamentoStatus);
        await dbContext.SaveChangesAsync();
        return programaRelacionamentoStatus;
    }

    public async Task<ProgramaRelacionamentoStatus?> UpdateProgramaRelacionamentoStatusByAsync(int id, UpdateProgramaRelacionamentoStatusDto updateProgramaRelacionamento)
    {
        var programaRelacStatus = await dbContext.ProgramaRelacionamentoStatus.FirstOrDefaultAsync(prs => prs.Id == id);
        if (programaRelacStatus == null)
        {
            return null;
        }
        
        programaRelacStatus.BeneficiarioId = updateProgramaRelacionamento.BeneficiarioId;
        programaRelacStatus.DataAdesao = updateProgramaRelacionamento.DataAdesao;
        programaRelacStatus.QtdePontos = updateProgramaRelacionamento.QtdePontos;
        
        await dbContext.SaveChangesAsync();
        return programaRelacStatus;
    }

    public async Task<ProgramaRelacionamentoStatus?> DeleteProgramaRelacionamentoStatusByAsync(int id)
    {
        var programaRelacStatus = await dbContext.ProgramaRelacionamentoStatus.FirstOrDefaultAsync(prs => prs.Id == id);
        if (programaRelacStatus == null)
        {
            return null;
        }
        
        dbContext.ProgramaRelacionamentoStatus.Remove(programaRelacStatus);
        await dbContext.SaveChangesAsync();
        return programaRelacStatus;
    }
}