using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.TipoServico;
using odontoprev_api_cs.Mappers.TipoServico;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/tipoServico")]
[ApiController]
public class TipoServicoController(ITipoServicoService tipoServicoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTipoServicos()
    {
        var tipoServico = await tipoServicoService.GetAllTipoServicosAsync();
        return Ok(tipoServico);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTipoServicoById(int id)
    {
        var tipoServico = await tipoServicoService.GetTipoServicoByIdAsync(id);
        if (tipoServico == null)
        {
            return NotFound();
        }

        return Ok(tipoServico);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTipoServico(CreateTipoServicoDto createTipoServicoDto)
    {
        var tipoServico = await tipoServicoService.CreateTipoServicoAsync(createTipoServicoDto);
        return CreatedAtAction(nameof(GetTipoServicoById), new {id = tipoServico.Id}, tipoServico);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTipoServico(int id, UpdateTipoServicoDto updateTipoServicoDto)
    {
        var tipoServico = await tipoServicoService.UpdateTipoServicoByAsync(id, updateTipoServicoDto);
        if (tipoServico == null)
        {
            return NotFound();
        }

        return Ok(tipoServico.ToTipoServicoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTipoServico(int id)
    {
        var deleted = await tipoServicoService.DeleteTipoServicoByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}