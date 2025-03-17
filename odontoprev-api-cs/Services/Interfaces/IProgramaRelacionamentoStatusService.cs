using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IProgramaRelacionamentoStatusService
{
    Task<List<ProgramaRelacionamentoStatus>> GetAllProgramaRelacionamentoStatussAsync();
    Task<ProgramaRelacionamentoStatus?> GetProgramaRelacionamentoStatusByIdAsync(int id);
    Task<ProgramaRelacionamentoStatus> CreateProgramaRelacionamentoStatusAsync(CreateProgramaRelacionamentoStatusDto createProgramaRelacionamentoStatusDto);
    Task<ProgramaRelacionamentoStatus?> UpdateProgramaRelacionamentoStatusByAsync(int id, UpdateProgramaRelacionamentoStatusDto updateProgramaRelacionamentoStatusDto);
    Task<bool> DeleteProgramaRelacionamentoStatusByAsync(int id);
}
