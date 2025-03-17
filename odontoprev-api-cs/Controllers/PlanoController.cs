using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Plano;
using odontoprev_api_cs.Mappers.Plano;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/plano")]
[ApiController]
public class PlanoController(IPlanoRepository planoRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPlanos()
    {
        var plano = await planoRepository.GetAllPlanosAsync();
        return Ok(plano);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPlanoById(int id)
    {
        var plano = await planoRepository.GetPlanoByIdAsync(id);
        if (plano == null)
        {
            return NotFound();
        }

        return Ok(plano);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePlano(CreatePlanoDto createPlanoDto)
    {
        var plano = createPlanoDto.ToPlanoFromCreate();
        await planoRepository.CreatePlanoAsync(plano);
        return CreatedAtAction(nameof(GetPlanoById), new {id = plano.Id}, plano);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdatePlano(int id, UpdatePlanoDto updatePlanoDto)
    {
        var plano = await planoRepository.UpdatePlanoByAsync(id, updatePlanoDto);
        if (plano == null)
        {
            return NotFound();
        }

        return Ok(plano.ToPlanoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeletePlano(int id)
    {
        var plano = await planoRepository.DeletePlanoByAsync(id);
        if (plano == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}