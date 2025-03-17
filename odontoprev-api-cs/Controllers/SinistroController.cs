using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Sinistro;
using odontoprev_api_cs.Mappers.Sinistro;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/sinistro")]
[ApiController]
public class SinistroController(ISinistroService sinistroService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSinistros()
    {
        var sinistro = await sinistroService.GetAllSinistrosAsync();
        return Ok(sinistro);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetSinistroById(int id)
    {
        var sinistro = await sinistroService.GetSinistroByIdAsync(id);
        if (sinistro == null)
        {
            return NotFound();
        }

        return Ok(sinistro);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSinistro(CreateSinistroDto createSinistroDto)
    {
        var sinistro = await sinistroService.CreateSinistroAsync(createSinistroDto);
        return CreatedAtAction(nameof(GetSinistroById), new {id = sinistro.Id}, sinistro);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Updatesinistro(int id, UpdateSinistroDto updateSinistroDto)
    {
        var sinistro = await sinistroService.UpdateSinistroByAsync(id, updateSinistroDto);
        if (sinistro == null)
        {
            return NotFound();
        }

        return Ok(sinistro.ToSinistroDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteSinistro(int id)
    {
        var deleted = await sinistroService.DeleteSinistroByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}