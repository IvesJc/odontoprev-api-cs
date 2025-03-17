using odontoprev_api_cs.DTOs.RedeCredenciada;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IRedeCredenciadaService
{
    Task<List<RedeCredenciada>> GetAllRedeCredenciadasAsync();
    Task<RedeCredenciada?> GetRedeCredenciadaByIdAsync(int id);
    Task<RedeCredenciada> CreateRedeCredenciadaAsync(CreateRedeCredenciadaDto createRedeCredenciadaDto);
    Task<RedeCredenciada?> UpdateRedeCredenciadaByAsync(int id, UpdateRedeCredenciadaDto updateRedeCredenciadaDto);
    Task<bool> DeleteRedeCredenciadaByAsync(int id);
}
