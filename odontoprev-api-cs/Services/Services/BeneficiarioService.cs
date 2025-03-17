using odontoprev_api_cs.DTOs.Beneficiario;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Beneficiario;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class BeneficiarioService(IBeneficiarioRepository beneficiarioRepository) : IBeneficiarioService
{
    public async Task<List<Beneficiario>> GetAllBeneficiariosAsync()
    {
        return await beneficiarioRepository.GetAllBeneficiariosAsync();
    }

    public async Task<Beneficiario?> GetBeneficiarioByIdAsync(int id)
    {
        return await beneficiarioRepository.GetBeneficiarioByIdAsync(id);
    }

    public async Task<Beneficiario> CreateBeneficiarioAsync(CreateBeneficiarioDto createBeneficiarioDto)
    {
        var beneficiario = createBeneficiarioDto.ToBeneficiarioFromCreate();
        await beneficiarioRepository.CreateBeneficiarioAsync(beneficiario);
        return beneficiario;
    }

    public async Task<Beneficiario?> UpdateBeneficiarioByAsync(int id, UpdateBeneficiarioDto updateBeneficiarioDto)
    {
        return await beneficiarioRepository.UpdateBeneficiarioByAsync(id, updateBeneficiarioDto);
    }

    public async Task<bool> DeleteBeneficiarioByAsync(int id)
    {
        var beneficiario = await beneficiarioRepository.DeleteBeneficiarioByAsync(id);
        return beneficiario != null;
    }
}