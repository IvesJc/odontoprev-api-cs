using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IPrestadorServicoRepository
{
    Task<List<PrestadorServico>> GetAllPrestadorServicosAsync();
    Task<PrestadorServico?> GetPrestadorServicoByIdAsync(int id);
    Task<PrestadorServico> CreatePrestadorServicoAsync(CreatePrestadorServicoDto prestadorServico);
    Task<PrestadorServico?> UpdatePrestadorServicoByAsync(int id, UpdatePrestadorServicoDto prestadorServico);
    Task<PrestadorServico?> DeletePrestadorServicoByAsync(int id);
}