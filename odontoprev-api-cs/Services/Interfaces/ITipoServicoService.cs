using odontoprev_api_cs.DTOs.TipoServico;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface ITipoServicoService
{
    Task<List<TipoServico>> GetAllTipoServicosAsync();
    Task<TipoServico?> GetTipoServicoByIdAsync(int id);
    Task<TipoServico> CreateTipoServicoAsync(CreateTipoServicoDto createTipoServicoDto);
    Task<TipoServico?> UpdateTipoServicoByAsync(int id, UpdateTipoServicoDto updateTipoServicoDto);
    Task<bool> DeleteTipoServicoByAsync(int id);
}
