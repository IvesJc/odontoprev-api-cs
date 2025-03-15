using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IProgramaRelacionamentoStatusRepository
{
    Task<List<ProgramaRelacionamentoStatus>> GetAllProgramaRelacionamentoStatussAsync();
    Task<ProgramaRelacionamentoStatus?> GetProgramaRelacionamentoStatusByIdAsync(int id);
    Task<ProgramaRelacionamentoStatus> CreateProgramaRelacionamentoStatusAsync(CreateProgramaRelacionamentoStatusDto programaRelacionamentoStatus);
    Task<ProgramaRelacionamentoStatus?> UpdateProgramaRelacionamentoStatusByAsync(int id, UpdateProgramaRelacionamentoStatusDto programaRelacionamentoStatus);
    Task<ProgramaRelacionamentoStatus?> DeleteProgramaRelacionamentoStatusByAsync(int id);
}