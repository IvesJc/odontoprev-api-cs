using odontoprev_api_cs.DTOs.Beneficiario;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Mappers.Beneficiario;

public static class BeneficiarioMapper
{
    public static BeneficiarioDto ToBeneficiarioDto(this Entities.Beneficiario beneficiario)
    {
        return new BeneficiarioDto
        {
            Id = beneficiario.Id,
            Nome = beneficiario.Nome,
            Cpf = beneficiario.Cpf,
            DataAdesao = beneficiario.DataAdesao,
            FotoUrl = beneficiario.FotoUrl,
            Telefone = beneficiario.Telefone,
            Tipo = (int)beneficiario.Tipo,
            Password = beneficiario.Password,
            NumeroContrato = beneficiario.NumeroContrato,
            EnderecoId = beneficiario.EnderecoId,
            EmpresaContratanteId = beneficiario.EmpresaContratanteId,
        };
    }

    public static Entities.Beneficiario ToBeneficiarioFromCreate(this CreateBeneficiarioDto beneficiarioDto)
    {
        return new Entities.Beneficiario
        {
            Nome = beneficiarioDto.Nome,
            Cpf = beneficiarioDto.Cpf,
            DataAdesao = beneficiarioDto.DataAdesao,
            FotoUrl = beneficiarioDto.FotoUrl,
            Telefone = beneficiarioDto.Telefone,
            Tipo = (TipoBeneficiarioEnum)beneficiarioDto.Tipo,
            Password = beneficiarioDto.Password,
            NumeroContrato = beneficiarioDto.NumeroContrato,
            EnderecoId = beneficiarioDto.EnderecoId,
            EmpresaContratanteId = beneficiarioDto.EmpresaContratanteId,
        };
    }
    
    public static Entities.Beneficiario ToBeneficiarioFromUpdate(this UpdateBeneficiarioDto beneficiarioDto)
    {
        return new Entities.Beneficiario
        {
            Nome = beneficiarioDto.Nome,
            Cpf = beneficiarioDto.Cpf,
            DataAdesao = beneficiarioDto.DataAdesao,
            FotoUrl = beneficiarioDto.FotoUrl,
            Telefone = beneficiarioDto.Telefone,
            Tipo = (TipoBeneficiarioEnum)beneficiarioDto.Tipo,
            Password = beneficiarioDto.Password,
            NumeroContrato = beneficiarioDto.NumeroContrato,
            EnderecoId = beneficiarioDto.EnderecoId,
            EmpresaContratanteId = beneficiarioDto.EmpresaContratanteId,
        };
    }
}