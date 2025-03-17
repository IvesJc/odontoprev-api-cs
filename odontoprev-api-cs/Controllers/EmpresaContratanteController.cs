using Microsoft.AspNetCore.Mvc;
using odontoprev_api_cs.DTOs.EmpresaContratante;
using odontoprev_api_cs.Mappers.EmpresaContratante;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Controllers;

[Route("api/empresaContratante")]
[ApiController]
public class EmpresaContratanteController(IEmpresaContratanteRepository empresaContratanteRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetEmpresaContratantes()
    {
        var empresaContratantes = await empresaContratanteRepository.GetAllEmpresaContratantesAsync();
        return Ok(empresaContratantes);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetEmpresaContratanteById(int id)
    {
        var empresaContratantes = await empresaContratanteRepository.GetEmpresaContratanteByIdAsync(id);
        if (empresaContratantes == null)
        {
            return NotFound();
        }

        return Ok(empresaContratantes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateempresaContratante(CreateEmpresaContratanteDto createEmpresaContratanteDto)
    {
        var empresaContratante = createEmpresaContratanteDto.ToEmpresaContratanteFromCreate();
        await empresaContratanteRepository.CreateEmpresaContratanteAsync(empresaContratante);
        return CreatedAtAction(nameof(GetEmpresaContratanteById), new {id = empresaContratante.Id}, empresaContratante);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateEmpresaContratante(int id, UpdateEmpresaContratanteDto updateempresaContratantesDto)
    {
        var empresaContratante = await empresaContratanteRepository.UpdateEmpresaContratanteByAsync(id, updateempresaContratantesDto);
        if (empresaContratante == null)
        {
            return NotFound();
        }

        return Ok(empresaContratante.ToEmpresaContratante());
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteEmpresaContratante(int id)
    {
        var empresaContratante = await empresaContratanteRepository.DeleteEmpresaContratanteByAsync(id);
        if (empresaContratante == null)
        {
            return NotFound();
        }

        return NoContent();
    }
}