using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class ProgramaRelacionamentoStatusService(IProgramaRelacionamentoStatusRepository programaRelacionamentoStatusRepository) : IProgramaRelacionamentoStatusService
{
    public async Task<List<ProgramaRelacionamentoStatus>> GetAllProgramaRelacionamentoStatussAsync()
    {
        return await programaRelacionamentoStatusRepository.GetAllProgramaRelacionamentoStatussAsync();
    }

    public async Task<ProgramaRelacionamentoStatus?> GetProgramaRelacionamentoStatusByIdAsync(int id)
    {
        return await programaRelacionamentoStatusRepository.GetProgramaRelacionamentoStatusByIdAsync(id);
    }

    public async Task<ProgramaRelacionamentoStatus> CreateProgramaRelacionamentoStatusAsync(CreateProgramaRelacionamentoStatusDto createProgramaRelacionamentoStatusDto)
    {
        var programaRelacionamentoStatus = createProgramaRelacionamentoStatusDto.ToProgramaRelacionamentoStatusFromCreate();
        await programaRelacionamentoStatusRepository.CreateProgramaRelacionamentoStatusAsync(programaRelacionamentoStatus);
        return programaRelacionamentoStatus;
    }

    public async Task<ProgramaRelacionamentoStatus?> UpdateProgramaRelacionamentoStatusByAsync(int id, UpdateProgramaRelacionamentoStatusDto updateProgramaRelacionamentoStatusDto)
    {
        return await programaRelacionamentoStatusRepository.UpdateProgramaRelacionamentoStatusByAsync(id, updateProgramaRelacionamentoStatusDto);
    }

    public async Task<bool> DeleteProgramaRelacionamentoStatusByAsync(int id)
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusRepository.DeleteProgramaRelacionamentoStatusByAsync(id);
        return programaRelacionamentoStatus != null;
    }
}