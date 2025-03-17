using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.TipoMissao;
using odontoprev_api_cs.Mappers.TipoMissao;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/tipoMissao")]
[ApiController]
public class TipoMissaoController(ITipoMissaoService tipoMissaoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTipoMissaos()
    {
        var tipoMissao = await tipoMissaoService.GetAllTipoMissaosAsync();
        return Ok(tipoMissao);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTipoMissaoById(int id)
    {
        var tipoMissao = await tipoMissaoService.GetTipoMissaoByIdAsync(id);
        if (tipoMissao == null)
        {
            return NotFound();
        }

        return Ok(tipoMissao);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTipoMissao(CreateTipoMissaoDto createTipoMissaoDto)
    {
        var tipoMissao = await tipoMissaoService.CreateTipoMissaoAsync(createTipoMissaoDto);
        return CreatedAtAction(nameof(GetTipoMissaoById), new {id = tipoMissao.Id}, tipoMissao);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTipoMissao(int id, UpdateTipoMissaoDto updateTipoMissaoDto)
    {
        var tipoMissao = await tipoMissaoService.UpdateTipoMissaoByAsync(id, updateTipoMissaoDto);
        if (tipoMissao == null)
        {
            return NotFound();
        }

        return Ok(tipoMissao.ToMissaoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTipoMissao(int id)
    {
        var deleted = await tipoMissaoService.DeleteTipoMissaoByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}