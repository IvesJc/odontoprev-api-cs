using odontoprev_api_cs.DTOs.PrestadorServico;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IPrestadorServicoService
{
    Task<List<PrestadorServico>> GetAllPrestadorServicosAsync();
    Task<PrestadorServico?> GetPrestadorServicoByIdAsync(int id);
    Task<PrestadorServico> CreatePrestadorServicoAsync(CreatePrestadorServicoDto createPrestadorServicoDto);
    Task<PrestadorServico?> UpdatePrestadorServicoByAsync(int id, UpdatePrestadorServicoDto updatePrestadorServicoDto);
    Task<bool> DeletePrestadorServicoByAsync(int id);
}
