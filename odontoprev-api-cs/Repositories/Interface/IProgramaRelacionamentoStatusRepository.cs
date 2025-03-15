using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IProgramaRelacionamentoStatusRepository
{
    Task<List<ProgramaRelacionamentoStatus>> GetAllProgramaRelacionamentoStatussAsync();
    Task<ProgramaRelacionamentoStatus?> GetProgramaRelacionamentoStatusByIdAsync(int id);
    Task<ProgramaRelacionamentoStatus> CreateProgramaRelacionamentoStatusAsync(ProgramaRelacionamentoStatus programaRelacionamentoStatus);
    Task<ProgramaRelacionamentoStatus?> UpdateProgramaRelacionamentoStatusByAsync(int id, ProgramaRelacionamentoStatus programaRelacionamentoStatus);
    Task<ProgramaRelacionamentoStatus?> DeleteProgramaRelacionamentoStatusByAsync(int id);
}