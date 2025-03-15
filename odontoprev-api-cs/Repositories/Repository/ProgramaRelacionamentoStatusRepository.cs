using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class ProgramaRelacionamentoStatusRepository(AppDbContext dbContext) :  IProgramaRelacionamentoStatusRepository
{
    public Task<List<ProgramaRelacionamentoStatus>> GetAllProgramaRelacionamentoStatussAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProgramaRelacionamentoStatus?> GetProgramaRelacionamentoStatusByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProgramaRelacionamentoStatus> CreateProgramaRelacionamentoStatusAsync(CreateProgramaRelacionamentoStatusDto programaRelacionamentoStatus)
    {
        throw new NotImplementedException();
    }

    public Task<ProgramaRelacionamentoStatus?> UpdateProgramaRelacionamentoStatusByAsync(int id, UpdateProgramaRelacionamentoStatusDto programaRelacionamentoStatus)
    {
        throw new NotImplementedException();
    }

    public Task<ProgramaRelacionamentoStatus?> DeleteProgramaRelacionamentoStatusByAsync(int id)
    {
        throw new NotImplementedException();
    }
}