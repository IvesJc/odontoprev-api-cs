using odontoprev_api_cs.DTOs.Endereco;

namespace odontoprev_api_cs.Mappers.Endereco;

public static class EnderecoMapper
{
    public static EnderecoDto ToEnderecoDto(this Entities.Endereco endereco)
    {
        return new EnderecoDto
        {
            Id = endereco.Id,
            Cep = endereco.Cep,
            Cidade = endereco.Cidade,
            Estado = endereco.Estado,
            Numero = endereco.Numero,
            Complemento = endereco.Complemento,
            Rua = endereco.Rua,
        };
    }

    public static Entities.Endereco ToEnderecoFromCreate(this CreateEnderecoDto dto)
    {
        return new Entities.Endereco
        {
            Cep = dto.Cep,
            Cidade = dto.Cidade,
            Estado = dto.Estado,
            Numero = dto.Numero,
            Complemento = dto.Complemento,
            Rua = dto.Rua,
        };
    }

    public static Entities.Endereco ToEnderecoFromUpdate(this UpdateEnderecoDto dto)
    {
        return new Entities.Endereco
        {
            Cep = dto.Cep,
            Cidade = dto.Cidade,
            Estado = dto.Estado,
            Numero = dto.Numero,
            Complemento = dto.Complemento,
            Rua = dto.Rua,
        };
    }
}