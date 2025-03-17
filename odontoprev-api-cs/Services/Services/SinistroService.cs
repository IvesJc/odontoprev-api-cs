using odontoprev_api_cs.DTOs.Sinistro;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Sinistro;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Services.Interfaces;

namespace odontoprev_api_cs.Services.Services;

public class SinistroService(ISinistroRepository sinistroRepository) : ISinistroService
{
    public async Task<List<Sinistro>> GetAllSinistrosAsync()
    {
        return await sinistroRepository.GetAllSinistrosAsync();
    }

    public async Task<Sinistro?> GetSinistroByIdAsync(int id)
    {
        return await sinistroRepository.GetSinistroByIdAsync(id);
    }

    public async Task<Sinistro> CreateSinistroAsync(CreateSinistroDto createSinistroDto)
    {
        var sinistro = createSinistroDto.ToSinistroFromCreate();
        await sinistroRepository.CreateSinistroAsync(sinistro);
        return sinistro;
    }

    public async Task<Sinistro?> UpdateSinistroByAsync(int id, UpdateSinistroDto updateSinistroDto)
    {
        return await sinistroRepository.UpdateSinistroByAsync(id, updateSinistroDto);
    }

    public async Task<bool> DeleteSinistroByAsync(int id)
    {
        var sinistro = await sinistroRepository.DeleteSinistroByAsync(id);
        return sinistro != null;
    }
}