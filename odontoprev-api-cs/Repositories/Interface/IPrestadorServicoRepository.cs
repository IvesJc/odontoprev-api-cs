using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IPrestadorServicoRepository
{
    Task<List<PrestadorServico>> GetAllPrestadorServicosAsync();
    Task<PrestadorServico?> GetPrestadorServicoByIdAsync(int id);
    Task<PrestadorServico> CreatePrestadorServicoAsync(PrestadorServico prestadorServico);
    Task<PrestadorServico?> UpdatePrestadorServicoByAsync(int id, PrestadorServico prestadorServico);
    Task<PrestadorServico?> DeletePrestadorServicoByAsync(int id);
}