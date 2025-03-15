using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class EmpresaContratanteRepository(AppDbContext dbContext) : IEmpresaContratanteRepository
{
    public Task<List<EmpresaContratante>> GetAllEmpresaContratantesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EmpresaContratante?> GetEmpresaContratanteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<EmpresaContratante> CreateEmpresaContratanteAsync(EmpresaContratante empresaContratante)
    {
        throw new NotImplementedException();
    }

    public Task<EmpresaContratante?> UpdateEmpresaContratanteByAsync(int id, EmpresaContratante empresaContratante)
    {
        throw new NotImplementedException();
    }

    public Task<EmpresaContratante?> DeleteEmpresaContratanteByAsync(int id)
    {
        throw new NotImplementedException();
    }
}