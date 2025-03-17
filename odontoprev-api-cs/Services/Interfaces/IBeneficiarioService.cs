using odontoprev_api_cs.DTOs.Beneficiario;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IBeneficiarioService
{
    Task<List<Beneficiario>> GetAllBeneficiariosAsync();
    Task<Beneficiario?> GetBeneficiarioByIdAsync(int id);
    Task<Beneficiario> CreateBeneficiarioAsync(CreateBeneficiarioDto createBeneficiarioDto);
    Task<Beneficiario?> UpdateBeneficiarioByAsync(int id, UpdateBeneficiarioDto updateBeneficiarioDto);
    Task<bool> DeleteBeneficiarioByAsync(int id);
}
