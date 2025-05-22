using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Missao;
using odontoprev_api_cs.Mappers.Missao;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/missao")]
[ApiController]
[Authorize]
public class MissaoController(IMissaoService missaoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetMissoes()
    {
        var missao = await missaoService.GetAllMissaosAsync();
        return Ok(missao);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMissaoById(int id)
    {
        var missao = await missaoService.GetMissaoByIdAsync(id);
        if (missao == null)
        {
            return NotFound();
        }

        return Ok(missao);
    }

    [HttpPost]
    public async Task<IActionResult> CreateMissao(CreateMissaoDto createMissaoDto)
    {
        var missao = await missaoService.CreateMissaoAsync(createMissaoDto);
        return CreatedAtAction(nameof(GetMissaoById), new {id = missao.Id}, missao);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateMissao(int id, UpdateMissaoDto updatemissaoDto)
    {
        var missao = await missaoService.UpdateMissaoByAsync(id, updatemissaoDto);
        if (missao == null)
        {
            return NotFound();
        }

        return Ok(missao.ToMissaoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Deletemissao(int id)
    {
        var deleted = await missaoService.DeleteMissaoByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}