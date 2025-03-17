using odontoprev_api_cs.DTOs.EmpresaContratante;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.EmpresaContratante;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class EmpresaContratanteService(IEmpresaContratanteRepository empresaContratanteRepository) : IEmpresaContratanteService
{
    public async Task<List<EmpresaContratante>> GetAllEmpresaContratantesAsync()
    {
        return await empresaContratanteRepository.GetAllEmpresaContratantesAsync();
    }

    public async Task<EmpresaContratante?> GetEmpresaContratanteByIdAsync(int id)
    {
        return await empresaContratanteRepository.GetEmpresaContratanteByIdAsync(id);
    }

    public async Task<EmpresaContratante> CreateEmpresaContratanteAsync(CreateEmpresaContratanteDto createEmpresaContratanteDto)
    {
        var empresaContratante = createEmpresaContratanteDto.ToEmpresaContratanteFromCreate();
        await empresaContratanteRepository.CreateEmpresaContratanteAsync(empresaContratante);
        return empresaContratante;
    }

    public async Task<EmpresaContratante?> UpdateEmpresaContratanteByAsync(int id, UpdateEmpresaContratanteDto updateEmpresaContratanteDto)
    {
        return await empresaContratanteRepository.UpdateEmpresaContratanteByAsync(id, updateEmpresaContratanteDto);
    }

    public async Task<bool> DeleteEmpresaContratanteByAsync(int id)
    {
        var empresaContratante = await empresaContratanteRepository.DeleteEmpresaContratanteByAsync(id);
        return empresaContratante != null;
    }
}