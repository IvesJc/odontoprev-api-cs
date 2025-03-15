using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IServicoRepository
{
    Task<List<Servico>> GetAllServicosAsync();
    Task<Servico?> GetServicoByIdAsync(int id);
    Task<Servico> CreateServicoAsync(Servico servico);
    Task<Servico?> UpdateServicoByAsync(int id, Servico servico);
    Task<Servico?> DeleteServicoByAsync(int id);
}