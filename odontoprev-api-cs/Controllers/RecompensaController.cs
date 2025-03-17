using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Recompensa;
using odontoprev_api_cs.Mappers.Recompensa;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/recompensa")]
[ApiController]
public class RecompensaController(IRecompensaRepository recompensaRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetRecompensas()
    {
        var recompensa = await recompensaRepository.GetAllRecompensasAsync();
        return Ok(recompensa);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetRecompensaById(int id)
    {
        var recompensa = await recompensaRepository.GetRecompensaByIdAsync(id);
        if (recompensa == null)
        {
            return NotFound();
        }

        return Ok(recompensa);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRecompensa(CreateRecompensaDto createRecompensaDto)
    {
        var recompensa = createRecompensaDto.ToRecompensaFromCreate();
        await recompensaRepository.CreateRecompensaAsync(recompensa);
        return CreatedAtAction(nameof(GetRecompensaById), new {id = recompensa.Id}, recompensa);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateRecompensa(int id, UpdateRecompensaDto updateRecompensaDto)
    {
        var recompensa = await recompensaRepository.UpdateRecompensaByAsync(id, updateRecompensaDto);
        if (recompensa == null)
        {
            return NotFound();
        }

        return Ok(recompensa.ToRecompensaDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteRecompensa(int id)
    {
        var recompensa = await recompensaRepository.DeleteRecompensaByAsync(id);
        if (recompensa == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}