using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Plano;
using odontoprev_api_cs.Mappers.Plano;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/plano")]
[ApiController]
[Authorize]
public class PlanoController(IPlanoService planoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPlanos()
    {
        var plano = await planoService.GetAllPlanosAsync();
        return Ok(plano);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPlanoById(int id)
    {
        var plano = await planoService.GetPlanoByIdAsync(id);
        if (plano == null)
        {
            return NotFound();
        }

        return Ok(plano);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePlano(CreatePlanoDto createPlanoDto)
    {
        var plano = await planoService.CreatePlanoAsync(createPlanoDto);
        return CreatedAtAction(nameof(GetPlanoById), new {id = plano.Id}, plano);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdatePlano(int id, UpdatePlanoDto updatePlanoDto)
    {
        var plano = await planoService.UpdatePlanoByAsync(id, updatePlanoDto);
        if (plano == null)
        {
            return NotFound();
        }

        return Ok(plano.ToPlanoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeletePlano(int id)
    {
        var deleted = await planoService.DeletePlanoByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}