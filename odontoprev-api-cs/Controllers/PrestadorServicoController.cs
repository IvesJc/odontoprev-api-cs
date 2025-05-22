using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Mappers.PrestadorServico;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/prestadorServico")]
[ApiController]
[Authorize]
public class PrestadorServicoController(IPrestadorServicoService prestadorServicoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPrestadorServicos()
    {
        var prestadorServico = await prestadorServicoService.GetAllPrestadorServicosAsync();
        return Ok(prestadorServico);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPrestadorServicoById(int id)
    {
        var prestadorServico = await prestadorServicoService.GetPrestadorServicoByIdAsync(id);
        if (prestadorServico == null)
        {
            return NotFound();
        }

        return Ok(prestadorServico);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePrestadorServico(CreatePrestadorServicoDto createPrestadorServicoDto)
    {
        var prestadorServico =  await prestadorServicoService.CreatePrestadorServicoAsync(createPrestadorServicoDto);
        return CreatedAtAction(nameof(GetPrestadorServicoById), new {id = prestadorServico.Id}, prestadorServico);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateprestadorServico(int id, UpdatePrestadorServicoDto updatePrestadorServicoDto)
    {
        var prestadorServico = await prestadorServicoService.UpdatePrestadorServicoByAsync(id, updatePrestadorServicoDto);
        if (prestadorServico == null)
        {
            return NotFound();
        }

        return Ok(prestadorServico.ToPrestadorServicoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteprestadorServico(int id)
    {
        var deleted = await prestadorServicoService.DeletePrestadorServicoByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}