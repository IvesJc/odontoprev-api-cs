using odontoprev_api_cs.DTOs.ProgramaRelacionamentoStatus;

namespace odontoprev_api_cs.Mappers.ProgramaRelacionamentoStatus;

public static class ProgramaRelacionamentoStatusMapper
{
    public static ProgramaRelacionamentoStatusDto ToRelacionamentoStatusDto(
        this Entities.ProgramaRelacionamentoStatus programaRelacionamentoStatus)
    {
        return new ProgramaRelacionamentoStatusDto
        {
            Id = programaRelacionamentoStatus.Id,
            BeneficiarioId = programaRelacionamentoStatus.BeneficiarioId,
            DataAdesao = programaRelacionamentoStatus.DataAdesao,
            QtdePontos = programaRelacionamentoStatus.QtdePontos,
        };
    }

    public static Entities.ProgramaRelacionamentoStatus ToProgramaRelacionamentoStatusFromCreate(
        this CreateProgramaRelacionamentoStatusDto dto)
    {
        return new Entities.ProgramaRelacionamentoStatus
        {
            BeneficiarioId = dto.BeneficiarioId,
            DataAdesao = dto.DataAdesao,
            QtdePontos = dto.QtdePontos,
        };
    }
    
    
    public static Entities.ProgramaRelacionamentoStatus ToProgramaRelacionamentoStatusFromUpdate(
        this UpdateProgramaRelacionamentoStatusDto dto)
    {
        return new Entities.ProgramaRelacionamentoStatus
        {
            BeneficiarioId = dto.BeneficiarioId,
            DataAdesao = dto.DataAdesao,
            QtdePontos = dto.QtdePontos,
        };
    }
    
    
}