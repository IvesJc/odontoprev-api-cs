using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IBeneficiarioRepository
{
    Task<List<Beneficiario>> GetAllBeneficiariosAsync();
    Task<Beneficiario?> GetBeneficiarioByIdAsync(int id);
    Task<Beneficiario> CreateBeneficiarioAsync(Beneficiario beneficiario);
    Task<Beneficiario?> UpdateBeneficiarioByAsync(int id, Beneficiario beneficiario);
    Task<Beneficiario?> DeleteBeneficiarioByAsync(int id);
}