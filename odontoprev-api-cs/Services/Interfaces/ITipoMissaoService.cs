using odontoprev_api_cs.DTOs.TipoMissao;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface ITipoMissaoService
{
    Task<List<TipoMissao>> GetAllTipoMissaosAsync();
    Task<TipoMissao?> GetTipoMissaoByIdAsync(int id);
    Task<TipoMissao> CreateTipoMissaoAsync(CreateTipoMissaoDto createTipoMissaoDto);
    Task<TipoMissao?> UpdateTipoMissaoByAsync(int id, UpdateTipoMissaoDto updateTipoMissaoDto);
    Task<bool> DeleteTipoMissaoByAsync(int id);
}
