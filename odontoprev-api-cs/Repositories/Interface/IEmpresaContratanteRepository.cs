using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IEmpresaContratanteRepository
{
    Task<List<EmpresaContratante>> GetAllEmpresaContratantesAsync();
    Task<EmpresaContratante?> GetEmpresaContratanteByIdAsync(int id);
    Task<EmpresaContratante> CreateEmpresaContratanteAsync(EmpresaContratante empresaContratante);
    Task<EmpresaContratante?> UpdateEmpresaContratanteByAsync(int id, EmpresaContratante empresaContratante);
    Task<EmpresaContratante?> DeleteEmpresaContratanteByAsync(int id);
}