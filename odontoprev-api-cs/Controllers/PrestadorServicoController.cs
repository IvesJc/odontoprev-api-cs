using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Mappers.PrestadorServico;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/prestadorServico")]
[ApiController]
public class PrestadorServicoController(IPrestadorServicoRepository prestadorServicoRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPrestadorServicos()
    {
        var prestadorServico = await prestadorServicoRepository.GetAllPrestadorServicosAsync();
        return Ok(prestadorServico);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPrestadorServicoById(int id)
    {
        var prestadorServico = await prestadorServicoRepository.GetPrestadorServicoByIdAsync(id);
        if (prestadorServico == null)
        {
            return NotFound();
        }

        return Ok(prestadorServico);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePrestadorServico(CreatePrestadorServicoDto createPrestadorServicoDto)
    {
        var prestadorServico = createPrestadorServicoDto.ToPrestadorServicoFromCreate();
        await prestadorServicoRepository.CreatePrestadorServicoAsync(prestadorServico);
        return CreatedAtAction(nameof(GetPrestadorServicoById), new {id = prestadorServico.Id}, prestadorServico);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateprestadorServico(int id, UpdatePrestadorServicoDto updatePrestadorServicoDto)
    {
        var prestadorServico = await prestadorServicoRepository.UpdatePrestadorServicoByAsync(id, updatePrestadorServicoDto);
        if (prestadorServico == null)
        {
            return NotFound();
        }

        return Ok(prestadorServico.ToPrestadorServicoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteprestadorServico(int id)
    {
        var prestadorServico = await prestadorServicoRepository.DeletePrestadorServicoByAsync(id);
        if (prestadorServico == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}