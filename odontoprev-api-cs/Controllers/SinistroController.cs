using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Sinistro;
using odontoprev_api_cs.Mappers.Sinistro;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/sinistro")]
[ApiController]
public class SinistroController(ISinistroRepository sinistroRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSinistros()
    {
        var sinistro = await sinistroRepository.GetAllSinistrosAsync();
        return Ok(sinistro);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetSinistroById(int id)
    {
        var sinistro = await sinistroRepository.GetSinistroByIdAsync(id);
        if (sinistro == null)
        {
            return NotFound();
        }

        return Ok(sinistro);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSinistro(CreateSinistroDto createSinistroDto)
    {
        var sinistro = createSinistroDto.ToSinistroFromCreate();
        await sinistroRepository.CreateSinistroAsync(sinistro);
        return CreatedAtAction(nameof(GetSinistroById), new {id = sinistro.Id}, sinistro);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Updatesinistro(int id, UpdateSinistroDto updateSinistroDto)
    {
        var sinistro = await sinistroRepository.UpdateSinistroByAsync(id, updateSinistroDto);
        if (sinistro == null)
        {
            return NotFound();
        }

        return Ok(sinistro.ToSinistroDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteSinistro(int id)
    {
        var sinistro = await sinistroRepository.DeleteSinistroByAsync(id);
        if (sinistro == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}