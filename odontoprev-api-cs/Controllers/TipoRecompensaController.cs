using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.TipoRecompensa;
using odontoprev_api_cs.Mappers.TipoRecompensa;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/tipoRecompensa")]
[ApiController]
public class TipoRecompensaController(ITipoRecompensaService tipoRecompensaService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTipoRecompensas()
    {
        var tipoRecompensa = await tipoRecompensaService.GetAllTipoRecompensasAsync();
        return Ok(tipoRecompensa);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTipoRecompensaById(int id)
    {
        var tipoRecompensa = await tipoRecompensaService.GetTipoRecompensaByIdAsync(id);
        if (tipoRecompensa == null)
        {
            return NotFound();
        }

        return Ok(tipoRecompensa);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTipoRecompensa(CreateTipoRecompensaDto createTipoRecompensaDto)
    {
        var tipoRecompensa = await tipoRecompensaService.CreateTipoRecompensaAsync(createTipoRecompensaDto);
        return CreatedAtAction(nameof(GetTipoRecompensaById), new {id = tipoRecompensa.Id}, tipoRecompensa);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTipoRecompensa(int id, UpdateTipoRecompensaDto updateTipoRecompensaDto)
    {
        var tipoRecompensa = await tipoRecompensaService.UpdateTipoRecompensaByAsync(id, updateTipoRecompensaDto);
        if (tipoRecompensa == null)
        {
            return NotFound();
        }

        return Ok(tipoRecompensa.ToTipoRecompensaDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTipoRecompensa(int id)
    {
        var deleted = await tipoRecompensaService.DeleteTipoRecompensaByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}