using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Endereco;
using odontoprev_api_cs.Mappers.Endereco;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/endereco")]
[ApiController]
public class EnderecoController(IEnderecoService enderecoService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetEnderecos()
    {
        var endereco = await enderecoService.GetAllEnderecosAsync();
        return Ok(endereco);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEnderecoById(int id)
    {
        var endereco = await enderecoService.GetEnderecoByIdAsync(id);
        if (endereco == null)
        {
            return NotFound();
        }

        return Ok(endereco);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEndereco(CreateEnderecoDto createEnderecoDto)
    {
        var endereco = await enderecoService.CreateEnderecoAsync(createEnderecoDto);
        return CreatedAtAction(nameof(GetEnderecoById), new {id = endereco.Id}, endereco);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateEndereco(int id, UpdateEnderecoDto updateEnderecoDto)
    {
        var endereco = await enderecoService.UpdateEnderecoByAsync(id, updateEnderecoDto);
        if (endereco == null)
        {
            return NotFound();
        }

        return Ok(endereco.ToEnderecoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteEndereco(int id)
    {
        var deleted = await enderecoService.DeleteEnderecoByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}