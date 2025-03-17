using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Missao;
using odontoprev_api_cs.Mappers.Missao;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/missao")]
[ApiController]
public class MissaoController(IMissaoRepository missaoRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetMissoes()
    {
        var missao = await missaoRepository.GetAllMissaosAsync();
        return Ok(missao);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMissaoById(int id)
    {
        var missao = await missaoRepository.GetMissaoByIdAsync(id);
        if (missao == null)
        {
            return NotFound();
        }

        return Ok(missao);
    }

    [HttpPost]
    public async Task<IActionResult> CreateMissao(CreateMissaoDto createMissaoDto)
    {
        var missao = createMissaoDto.ToMissaoFromCreate();
        await missaoRepository.CreateMissaoAsync(missao);
        return CreatedAtAction(nameof(GetMissaoById), new {id = missao.Id}, missao);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateMissao(int id, UpdateMissaoDto updatemissaoDto)
    {
        var missao = await missaoRepository.UpdateMissaoByAsync(id, updatemissaoDto);
        if (missao == null)
        {
            return NotFound();
        }

        return Ok(missao.ToMissaoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Deletemissao(int id)
    {
        var missao = await missaoRepository.DeleteMissaoByAsync(id);
        if (missao == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}