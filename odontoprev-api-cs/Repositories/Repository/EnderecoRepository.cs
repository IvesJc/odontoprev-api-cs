using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Endereco;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Mappers.Endereco;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class EnderecoRepository(AppDbContext dbContext) : IEnderecoRepository
{
    public async Task<List<Endereco>> GetAllEnderecosAsync()
    {
        return await dbContext.Endereco.ToListAsync();
    }

    public async Task<Endereco?> GetEnderecoByIdAsync(int id)
    {
        return await dbContext.Endereco.FindAsync(id);
    }

    public async Task<Endereco> CreateEnderecoAsync(Endereco endereco)
    {
        await dbContext.AddAsync(endereco);
        await dbContext.SaveChangesAsync();
        return endereco;
    }

    public async Task<Endereco?> UpdateEnderecoByAsync(int id, UpdateEnderecoDto updateEnderecoDto)
    {
        var endereco = await dbContext.Endereco.FirstOrDefaultAsync(end => end.Id == id);
        if (endereco == null)
        {
            return null;
        }
        
        endereco.Cep = updateEnderecoDto.Cep;
        endereco.Cidade = updateEnderecoDto.Cidade;
        endereco.Complemento = updateEnderecoDto.Complemento;
        endereco.Estado = updateEnderecoDto.Estado;
        endereco.Numero = updateEnderecoDto.Numero;
        endereco.Rua = updateEnderecoDto.Rua;
        
        await dbContext.SaveChangesAsync();
        return endereco;
    }

    public async Task<Endereco?> DeleteEnderecoByAsync(int id)
    {
        var endereco = await dbContext.Endereco.FirstOrDefaultAsync(end => end.Id == id);
        if (endereco == null)
        {
            return null;
        }

        dbContext.Endereco.Remove(endereco);
        await dbContext.SaveChangesAsync();
        return endereco;
    }
}