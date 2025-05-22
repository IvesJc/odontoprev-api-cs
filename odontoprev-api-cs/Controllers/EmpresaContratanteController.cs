using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.EmpresaContratante;
using odontoprev_api_cs.Mappers.EmpresaContratante;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Controllers;

[Route("api/empresaContratante")]
[ApiController]
[Authorize]
public class EmpresaContratanteController(IEmpresaContratanteService empresaContratanteService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetEmpresaContratantes()
    {
        var empresaContratantes = await empresaContratanteService.GetAllEmpresaContratantesAsync();
        return Ok(empresaContratantes);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEmpresaContratanteById(int id)
    {
        var empresaContratantes = await empresaContratanteService.GetEmpresaContratanteByIdAsync(id);
        if (empresaContratantes == null)
        {
            return NotFound();
        }

        return Ok(empresaContratantes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateempresaContratante(CreateEmpresaContratanteDto createEmpresaContratanteDto)
    {
        var empresaContratante =
            await empresaContratanteService.CreateEmpresaContratanteAsync(createEmpresaContratanteDto);

        return CreatedAtAction(nameof(GetEmpresaContratanteById), new { id = empresaContratante.Id },
            empresaContratante);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateEmpresaContratante(int id,
        UpdateEmpresaContratanteDto updateempresaContratantesDto)
    {
        var empresaContratante =
            await empresaContratanteService.UpdateEmpresaContratanteByAsync(id, updateempresaContratantesDto);
        if (empresaContratante == null)
        {
            return NotFound();
        }

        return Ok(empresaContratante.ToEmpresaContratante());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteEmpresaContratante(int id)
    {
        var deleted = await empresaContratanteService.DeleteEmpresaContratanteByAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}