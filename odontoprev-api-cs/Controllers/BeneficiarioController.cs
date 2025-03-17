using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Beneficiario;
using odontoprev_api_cs.Mappers.Beneficiario;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/beneficiario")]
[ApiController]
public class BeneficiarioController(IBeneficiarioRepository beneficiarioRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetBeneficiarios()
    {
        var beneficiarios = await beneficiarioRepository.GetAllBeneficiariosAsync();
        return Ok(beneficiarios);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetBeneficiarioById(int id)
    {
        var beneficiario = await beneficiarioRepository.GetBeneficiarioByIdAsync(id);
        if (beneficiario == null)
        {
            return NotFound();
        }

        return Ok(beneficiario);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBeneficiario(CreateBeneficiarioDto createBeneficiarioDto)
    {
        var beneficiario = createBeneficiarioDto.ToBeneficiarioFromCreate();
        await beneficiarioRepository.CreateBeneficiarioAsync(beneficiario);
        return CreatedAtAction(nameof(GetBeneficiarioById), new {id = beneficiario.Id}, beneficiario);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateBeneficiario(int id, UpdateBeneficiarioDto updateBeneficiarioDto)
    {
        var beneficiario = await beneficiarioRepository.UpdateBeneficiarioByAsync(id, updateBeneficiarioDto);
        if (beneficiario == null)
        {
            return NotFound();
        }

        return Ok(beneficiario.ToBeneficiarioDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBeneficiario(int id)
    {
        var beneficiario = await beneficiarioRepository.DeleteBeneficiarioByAsync(id);
        if (beneficiario == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}