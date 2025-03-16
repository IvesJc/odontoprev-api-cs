using odontoprev_api_cs.DTOs.EmpresaContratante;

namespace odontoprev_api_cs.Mappers.EmpresaContratante;

public static class EmpresaContratanteMapper
{
    public static EmpresaContratanteDto ToEmpresaContratante(this Entities.EmpresaContratante empresaContratante)
    {
        return new EmpresaContratanteDto
        {
            Id = empresaContratante.Id,
            Nome = empresaContratante.Nome,
            Cnpj = empresaContratante.Cnpj,
            NumeroContrato = empresaContratante.NumeroContrato,
        };
    }

    public static Entities.EmpresaContratante ToEmpresaContratanteFromCreate(this CreateEmpresaContratanteDto dto)
    {
        return new Entities.EmpresaContratante
        {
            Nome = dto.Nome,
            Cnpj = dto.Cnpj,
            NumeroContrato = dto.NumeroContrato,
        };
    }
    public static Entities.EmpresaContratante ToEmpresaContratanteFromUpdate(this UpdateEmpresaContratanteDto dto)
    {
        return new Entities.EmpresaContratante
        {
            Nome = dto.Nome,
            Cnpj = dto.Cnpj,
            NumeroContrato = dto.NumeroContrato,
        };
    }
}