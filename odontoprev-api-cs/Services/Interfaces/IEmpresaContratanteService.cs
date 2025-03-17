using odontoprev_api_cs.DTOs.EmpresaContratante;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IEmpresaContratanteService
{
    Task<List<EmpresaContratante>> GetAllEmpresaContratantesAsync();
    Task<EmpresaContratante?> GetEmpresaContratanteByIdAsync(int id);
    Task<EmpresaContratante> CreateEmpresaContratanteAsync(CreateEmpresaContratanteDto createEmpresaContratanteDto);
    Task<EmpresaContratante?> UpdateEmpresaContratanteByAsync(int id, UpdateEmpresaContratanteDto updateEmpresaContratanteDto);
    Task<bool> DeleteEmpresaContratanteByAsync(int id);
}
