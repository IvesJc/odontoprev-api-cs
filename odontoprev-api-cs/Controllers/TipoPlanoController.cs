using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.TipoPlano;
using odontoprev_api_cs.Mappers.TipoPlano;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/tipoPlano")]
[ApiController]
public class TipoPlanoController(ITipoPlanoRepository tipoPlanoRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTipoPlanos()
    {
        var tipoPlano = await tipoPlanoRepository.GetAllTipoPlanosAsync();
        return Ok(tipoPlano);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTipoPlanoById(int id)
    {
        var tipoPlano = await tipoPlanoRepository.GetTipoPlanoByIdAsync(id);
        if (tipoPlano == null)
        {
            return NotFound();
        }

        return Ok(tipoPlano);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTipoPlano(CreateTipoPlanoDto createTipoPlanoDto)
    {
        var tipoPlano = createTipoPlanoDto.ToTipoPlanoFromCreate();
        await tipoPlanoRepository.CreateTipoPlanoAsync(tipoPlano);
        return CreatedAtAction(nameof(GetTipoPlanoById), new {id = tipoPlano.Id}, tipoPlano);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTipoPlano(int id, UpdateTipoPlanoDto updateTipoPlanoDto)
    {
        var tipoPlano = await tipoPlanoRepository.UpdateTipoPlanoByAsync(id, updateTipoPlanoDto);
        if (tipoPlano == null)
        {
            return NotFound();
        }

        return Ok(tipoPlano.ToTipoPlanoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTipoPlano(int id)
    {
        var tipoPlano = await tipoPlanoRepository.DeleteTipoPlanoByAsync(id);
        if (tipoPlano == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}