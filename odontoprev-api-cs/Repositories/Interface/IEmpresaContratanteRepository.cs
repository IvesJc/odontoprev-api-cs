using odontoprev_api_cs.DTOs.EmpresaContratante;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IEmpresaContratanteRepository
{
    Task<List<EmpresaContratante>> GetAllEmpresaContratantesAsync();
    Task<EmpresaContratante?> GetEmpresaContratanteByIdAsync(int id);
    Task<EmpresaContratante> CreateEmpresaContratanteAsync(CreateEmpresaContratanteDto empresaContratante);
    Task<EmpresaContratante?> UpdateEmpresaContratanteByAsync(int id, UpdateEmpresaContratanteDto empresaContratante);
    Task<EmpresaContratante?> DeleteEmpresaContratanteByAsync(int id);
}