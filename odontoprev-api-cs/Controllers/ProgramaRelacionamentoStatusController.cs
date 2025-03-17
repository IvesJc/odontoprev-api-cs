using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Mappers.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/programaRelacionamentoStatus")]
[ApiController]
public class ProgramaRelacionamentoStatusController(IProgramaRelacionamentoStatusRepository programaRelacionamentoStatusRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProgramaRelacionamentoStatuss()
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusRepository.GetAllProgramaRelacionamentoStatussAsync();
        return Ok(programaRelacionamentoStatus);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProgramaRelacionamentoStatusById(int id)
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusRepository.GetProgramaRelacionamentoStatusByIdAsync(id);
        if (programaRelacionamentoStatus == null)
        {
            return NotFound();
        }

        return Ok(programaRelacionamentoStatus);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProgramaRelacionamentoStatus(CreateProgramaRelacionamentoStatusDto createProgramaRelacionamentoStatusDto)
    {
        var programaRelacionamentoStatus = createProgramaRelacionamentoStatusDto.ToProgramaRelacionamentoStatusFromCreate();
        await programaRelacionamentoStatusRepository.CreateProgramaRelacionamentoStatusAsync(programaRelacionamentoStatus);
        return CreatedAtAction(nameof(GetProgramaRelacionamentoStatusById), new {id = programaRelacionamentoStatus.Id}, programaRelacionamentoStatus);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateprogramaRelacionamentoStatus(int id, UpdateProgramaRelacionamentoStatusDto updateprogramaRelacionamentoStatusDto)
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusRepository.UpdateProgramaRelacionamentoStatusByAsync(id, updateprogramaRelacionamentoStatusDto);
        if (programaRelacionamentoStatus == null)
        {
            return NotFound();
        }

        return Ok(programaRelacionamentoStatus.ToRelacionamentoStatusDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteprogramaRelacionamentoStatus(int id)
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusRepository.DeleteProgramaRelacionamentoStatusByAsync(id);
        if (programaRelacionamentoStatus == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}