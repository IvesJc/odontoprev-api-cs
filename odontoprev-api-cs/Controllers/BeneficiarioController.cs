using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.Beneficiario;
using odontoprev_api_cs.Mappers.Beneficiario;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/beneficiario")]
[ApiController]
public class BeneficiarioController(IBeneficiarioService beneficiarioService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetBeneficiarios()
    {
        var beneficiarios = await beneficiarioService.GetAllBeneficiariosAsync();
        return Ok(beneficiarios);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetBeneficiarioById(int id)
    {
        var beneficiario = await beneficiarioService.GetBeneficiarioByIdAsync(id);
        if (beneficiario == null)
        {
            return NotFound();
        }

        return Ok(beneficiario);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBeneficiario(CreateBeneficiarioDto createBeneficiarioDto)
    {
        var beneficiario = await beneficiarioService.CreateBeneficiarioAsync(createBeneficiarioDto);
        return CreatedAtAction(nameof(GetBeneficiarioById), new { id = beneficiario.Id }, beneficiario);
    }


    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateBeneficiario(int id, UpdateBeneficiarioDto updateBeneficiarioDto)
    {
        var beneficiario = await beneficiarioService.UpdateBeneficiarioByAsync(id, updateBeneficiarioDto);
        if (beneficiario == null)
        {
            return NotFound();
        }

        return Ok(beneficiario.ToBeneficiarioDto());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBeneficiario(int id)
    {
        var deleted = await beneficiarioService.DeleteBeneficiarioByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}