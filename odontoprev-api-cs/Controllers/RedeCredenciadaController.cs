using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.RedeCredenciada;
using odontoprev_api_cs.Mappers.RedeCredenciada;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/redeCredenciada")]
[ApiController]
public class RedeCredenciadaController(IRedeCredenciadaRepository redeCredenciadaRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetRedeCredenciadas()
    {
        var redeCredenciada = await redeCredenciadaRepository.GetAllRedeCredenciadasAsync();
        return Ok(redeCredenciada);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetRedeCredenciadaById(int id)
    {
        var redeCredenciada = await redeCredenciadaRepository.GetRedeCredenciadaByIdAsync(id);
        if (redeCredenciada == null)
        {
            return NotFound();
        }

        return Ok(redeCredenciada);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRedeCredenciada(CreateRedeCredenciadaDto createRedeCredenciadaDto)
    {
        var redeCredenciada = createRedeCredenciadaDto.ToRedeCredenciadaFromCreate();
        await redeCredenciadaRepository.CreateRedeCredenciadaAsync(redeCredenciada);
        return CreatedAtAction(nameof(GetRedeCredenciadaById), new {id = redeCredenciada.Id}, redeCredenciada);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateRedeCredenciada(int id, UpdateRedeCredenciadaDto updateredeCredenciadaDto)
    {
        var redeCredenciada = await redeCredenciadaRepository.UpdateRedeCredenciadaByAsync(id, updateredeCredenciadaDto);
        if (redeCredenciada == null)
        {
            return NotFound();
        }

        return Ok(redeCredenciada.ToRedeCredenciadaDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteRedeCredenciada(int id)
    {
        var redeCredenciada = await redeCredenciadaRepository.DeleteRedeCredenciadaByAsync(id);
        if (redeCredenciada == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}