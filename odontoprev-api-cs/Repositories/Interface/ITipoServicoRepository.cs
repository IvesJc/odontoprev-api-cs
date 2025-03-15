using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface ITipoServicoRepository
{
    Task<List<TipoServico>> GetAllTipoServicosAsync();
    Task<TipoServico?> GetTipoServicoByIdAsync(int id);
    Task<TipoServico> CreateTipoServicoAsync(TipoServico tipoServico);
    Task<TipoServico?> UpdateTipoServicoByAsync(int id, TipoServico tipoServico);
    Task<TipoServico?> DeleteTipoServicoByAsync(int id);
}