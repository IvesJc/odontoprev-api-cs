using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.TipoServico;
using odontoprev_api_cs.Mappers.TipoServico;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/tipoServico")]
[ApiController]
public class TipoServicoController(ITipoServicoRepository tipoServicoRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTipoServicos()
    {
        var tipoServico = await tipoServicoRepository.GetAllTipoServicosAsync();
        return Ok(tipoServico);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTipoServicoById(int id)
    {
        var tipoServico = await tipoServicoRepository.GetTipoServicoByIdAsync(id);
        if (tipoServico == null)
        {
            return NotFound();
        }

        return Ok(tipoServico);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTipoServico(CreateTipoServicoDto createTipoServicoDto)
    {
        var tipoServico = createTipoServicoDto.ToTipoServicoFromCreate();
        await tipoServicoRepository.CreateTipoServicoAsync(tipoServico);
        return CreatedAtAction(nameof(GetTipoServicoById), new {id = tipoServico.Id}, tipoServico);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateTipoServico(int id, UpdateTipoServicoDto updateTipoServicoDto)
    {
        var tipoServico = await tipoServicoRepository.UpdateTipoServicoByAsync(id, updateTipoServicoDto);
        if (tipoServico == null)
        {
            return NotFound();
        }

        return Ok(tipoServico.ToTipoServicoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTipoServico(int id)
    {
        var tipoServico = await tipoServicoRepository.DeleteTipoServicoByAsync(id);
        if (tipoServico == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}