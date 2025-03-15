using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class BeneficiarioRepository(AppDbContext dbContext) : IBeneficiarioRepository
{
    public Task<List<Beneficiario>> GetAllBeneficiariosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Beneficiario?> GetBeneficiarioByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Beneficiario> CreateBeneficiarioAsync(Beneficiario beneficiario)
    {
        throw new NotImplementedException();
    }

    public Task<Beneficiario?> UpdateBeneficiarioByAsync(int id, Beneficiario beneficiario)
    {
        throw new NotImplementedException();
    }

    public Task<Beneficiario?> DeleteBeneficiarioByAsync(int id)
    {
        throw new NotImplementedException();
    }
}