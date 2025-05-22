using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Mappers.ProgramaRelacionamentoStatus;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/programaRelacionamentoStatus")]
[ApiController]
[Authorize]
public class ProgramaRelacionamentoStatusController(IProgramaRelacionamentoStatusService programaRelacionamentoStatusService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProgramaRelacionamentoStatuss()
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusService.GetAllProgramaRelacionamentoStatussAsync();
        return Ok(programaRelacionamentoStatus);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProgramaRelacionamentoStatusById(int id)
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusService.GetProgramaRelacionamentoStatusByIdAsync(id);
        if (programaRelacionamentoStatus == null)
        {
            return NotFound();
        }

        return Ok(programaRelacionamentoStatus);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProgramaRelacionamentoStatus(CreateProgramaRelacionamentoStatusDto createProgramaRelacionamentoStatusDto)
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusService.CreateProgramaRelacionamentoStatusAsync(createProgramaRelacionamentoStatusDto);
        return CreatedAtAction(nameof(GetProgramaRelacionamentoStatusById), new {id = programaRelacionamentoStatus.Id}, programaRelacionamentoStatus);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateprogramaRelacionamentoStatus(int id, UpdateProgramaRelacionamentoStatusDto updateprogramaRelacionamentoStatusDto)
    {
        var programaRelacionamentoStatus = await programaRelacionamentoStatusService.UpdateProgramaRelacionamentoStatusByAsync(id, updateprogramaRelacionamentoStatusDto);
        if (programaRelacionamentoStatus == null)
        {
            return NotFound();
        }

        return Ok(programaRelacionamentoStatus.ToRelacionamentoStatusDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteprogramaRelacionamentoStatus(int id)
    {
        var deleted = await programaRelacionamentoStatusService.DeleteProgramaRelacionamentoStatusByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}