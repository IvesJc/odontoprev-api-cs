using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Endereco;
using odontoprev_api_cs.Mappers.Endereco;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/endereco")]
[ApiController]
public class EnderecoController(IEnderecoRepository enderecoRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetEnderecos()
    {
        var endereco = await enderecoRepository.GetAllEnderecosAsync();
        return Ok(endereco);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEnderecoById(int id)
    {
        var endereco = await enderecoRepository.GetEnderecoByIdAsync(id);
        if (endereco == null)
        {
            return NotFound();
        }

        return Ok(endereco);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEndereco(CreateEnderecoDto createEnderecoDto)
    {
        var endereco = createEnderecoDto.ToEnderecoFromCreate();
        await enderecoRepository.CreateEnderecoAsync(endereco);
        return CreatedAtAction(nameof(GetEnderecoById), new {id = endereco.Id}, endereco);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateEndereco(int id, UpdateEnderecoDto updateEnderecoDto)
    {
        var endereco = await enderecoRepository.UpdateEnderecoByAsync(id, updateEnderecoDto);
        if (endereco == null)
        {
            return NotFound();
        }

        return Ok(endereco.ToEnderecoDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteEndereco(int id)
    {
        var endereco = await enderecoRepository.DeleteEnderecoByAsync(id);
        if (endereco == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}