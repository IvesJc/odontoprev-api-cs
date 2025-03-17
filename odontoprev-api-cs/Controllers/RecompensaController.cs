using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Recompensa;
using odontoprev_api_cs.Mappers.Recompensa;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/recompensa")]
[ApiController]
public class RecompensaController(IRecompensaService recompensaService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetRecompensas()
    {
        var recompensa = await recompensaService.GetAllRecompensasAsync();
        return Ok(recompensa);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetRecompensaById(int id)
    {
        var recompensa = await recompensaService.GetRecompensaByIdAsync(id);
        if (recompensa == null)
        {
            return NotFound();
        }

        return Ok(recompensa);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRecompensa(CreateRecompensaDto createRecompensaDto)
    {
        var recompensa = await recompensaService.CreateRecompensaAsync(createRecompensaDto);
        return CreatedAtAction(nameof(GetRecompensaById), new {id = recompensa.Id}, recompensa);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateRecompensa(int id, UpdateRecompensaDto updateRecompensaDto)
    {
        var recompensa = await recompensaService.UpdateRecompensaByAsync(id, updateRecompensaDto);
        if (recompensa == null)
        {
            return NotFound();
        }

        return Ok(recompensa.ToRecompensaDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteRecompensa(int id)
    {
        var deleted = await recompensaService.DeleteRecompensaByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}