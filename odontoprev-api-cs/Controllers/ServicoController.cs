using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Servico;
using odontoprev_api_cs.Mappers.Servico;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/servico")]
[ApiController]
public class ServicoController(IServicoRepository servicoRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetServicos()
    {
        var servico = await servicoRepository.GetAllServicosAsync();
        return Ok(servico);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetServicoById(int id)
    {
        var servico = await servicoRepository.GetServicoByIdAsync(id);
        if (servico == null)
        {
            return NotFound();
        }

        return Ok(servico);
    }

    [HttpPost]
    public async Task<IActionResult> CreateServico(CreateServicoDto createServicoDto)
    {
        var servico = createServicoDto.ToServicoFromCreate();
        await servicoRepository.CreateServicoAsync(servico);
        return CreatedAtAction(nameof(GetServicoById), new {id = servico.Id}, servico);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Updateservico(int id, UpdateServicoDto updateServicoDto)
    {
        var servico = await servicoRepository.UpdateServicoByAsync(id, updateServicoDto);
        if (servico == null)
        {
            return NotFound();
        }

        return Ok(servico.ToServicoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteServico(int id)
    {
        var servico = await servicoRepository.DeleteServicoByAsync(id);
        if (servico == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}