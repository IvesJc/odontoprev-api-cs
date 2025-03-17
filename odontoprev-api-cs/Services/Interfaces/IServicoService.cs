using odontoprev_api_cs.DTOs.Servico;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Services.Interfaces;

public interface IServicoService
{
    Task<List<Servico>> GetAllServicosAsync();
    Task<Servico?> GetServicoByIdAsync(int id);
    Task<Servico> CreateServicoAsync(CreateServicoDto createServicoDto);
    Task<Servico?> UpdateServicoByAsync(int id, UpdateServicoDto updateServicoDto);
    Task<bool> DeleteServicoByAsync(int id);
}
