using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.RedeCredenciada;
using odontoprev_api_cs.Mappers.RedeCredenciada;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/redeCredenciada")]
[ApiController]
public class RedeCredenciadaController(IRedeCredenciadaService redeCredenciadaService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetRedeCredenciadas()
    {
        var redeCredenciada = await redeCredenciadaService.GetAllRedeCredenciadasAsync();
        return Ok(redeCredenciada);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetRedeCredenciadaById(int id)
    {
        var redeCredenciada = await redeCredenciadaService.GetRedeCredenciadaByIdAsync(id);
        if (redeCredenciada == null)
        {
            return NotFound();
        }

        return Ok(redeCredenciada);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRedeCredenciada(CreateRedeCredenciadaDto createRedeCredenciadaDto)
    {
        var redeCredenciada = await redeCredenciadaService.CreateRedeCredenciadaAsync(createRedeCredenciadaDto);
        return CreatedAtAction(nameof(GetRedeCredenciadaById), new {id = redeCredenciada.Id}, redeCredenciada);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateRedeCredenciada(int id, UpdateRedeCredenciadaDto updateredeCredenciadaDto)
    {
        var redeCredenciada = await redeCredenciadaService.UpdateRedeCredenciadaByAsync(id, updateredeCredenciadaDto);
        if (redeCredenciada == null)
        {
            return NotFound();
        }

        return Ok(redeCredenciada.ToRedeCredenciadaDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteRedeCredenciada(int id)
    {
        var deleted = await redeCredenciadaService.DeleteRedeCredenciadaByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}