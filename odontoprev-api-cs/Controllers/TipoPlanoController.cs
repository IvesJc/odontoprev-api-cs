using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.TipoPlano;
using odontoprev_api_cs.Mappers.TipoPlano;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/tipoPlano")]
[ApiController]
public class TipoPlanoController(ITipoPlanoService tipoPlanoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTipoPlanos()
    {
        var tipoPlano = await tipoPlanoService.GetAllTipoPlanosAsync();
        return Ok(tipoPlano);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTipoPlanoById(int id)
    {
        var tipoPlano = await tipoPlanoService.GetTipoPlanoByIdAsync(id);
        if (tipoPlano == null)
        {
            return NotFound();
        }

        return Ok(tipoPlano);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTipoPlano(CreateTipoPlanoDto createTipoPlanoDto)
    {
        var tipoPlano = await tipoPlanoService.CreateTipoPlanoAsync(createTipoPlanoDto);
        return CreatedAtAction(nameof(GetTipoPlanoById), new {id = tipoPlano.Id}, tipoPlano);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTipoPlano(int id, UpdateTipoPlanoDto updateTipoPlanoDto)
    {
        var tipoPlano = await tipoPlanoService.UpdateTipoPlanoByAsync(id, updateTipoPlanoDto);
        if (tipoPlano == null)
        {
            return NotFound();
        }

        return Ok(tipoPlano.ToTipoPlanoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTipoPlano(int id)
    {
        var deleted = await tipoPlanoService.DeleteTipoPlanoByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}