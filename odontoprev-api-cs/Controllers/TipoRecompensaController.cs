using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Mappers.TipoRecompensa;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/tipoRecompensa")]
[ApiController]
public class TipoRecompensaController(ITipoRecompensaRepository tipoRecompensaRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTipoRecompensas()
    {
        var tipoRecompensa = await tipoRecompensaRepository.GetAllTipoRecompensasAsync();
        return Ok(tipoRecompensa);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTipoRecompensaById(int id)
    {
        var tipoRecompensa = await tipoRecompensaRepository.GetTipoRecompensaByIdAsync(id);
        if (tipoRecompensa == null)
        {
            return NotFound();
        }

        return Ok(tipoRecompensa);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTipoRecompensa(CreateTipoRecompensaDto createTipoRecompensaDto)
    {
        var tipoRecompensa = createTipoRecompensaDto.ToTipoRecompensaFromCreate();
        await tipoRecompensaRepository.CreateTipoRecompensaAsync(tipoRecompensa);
        return CreatedAtAction(nameof(GetTipoRecompensaById), new {id = tipoRecompensa.Id}, tipoRecompensa);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTipoRecompensa(int id, UpdateTipoRecompensaDto updateTipoRecompensaDto)
    {
        var tipoRecompensa = await tipoRecompensaRepository.UpdateTipoRecompensaByAsync(id, updateTipoRecompensaDto);
        if (tipoRecompensa == null)
        {
            return NotFound();
        }

        return Ok(tipoRecompensa.ToTipoRecompensaDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTipoRecompensa(int id)
    {
        var tipoRecompensa = await tipoRecompensaRepository.DeleteTipoRecompensaByAsync(id);
        if (tipoRecompensa == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}