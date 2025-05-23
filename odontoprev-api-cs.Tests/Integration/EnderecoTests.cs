using System.ComponentModel.DataAnnotations;
using odontoprev_api_cs.Entities;
using Xunit;
using System.Collections.Generic;

namespace odontoprev_api_cs.Tests.Entities
{
    public class EnderecoTests
    {
        private IList<ValidationResult> ValidateModel(object model)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, context, results, true);
            return results;
        }

        [Fact]
        public void Endereco_Valido_NaoDeveTerErros()
        {
            var endereco = new Endereco
            {
                Rua = "Rua das Flores",
                Numero = 123,
                Cidade = "São Paulo",
                Estado = "SP",
                Cep = "12345-678",
                Complemento = "Apto 10"
            };

            var result = ValidateModel(endereco);

            Assert.Empty(result); // Não deve haver erros de validação
        }

        [Fact]
        public void Endereco_ComCepInvalido_DeveRetornarErro()
        {
            var endereco = new Endereco
            {
                Rua = "Rua das Flores",
                Numero = 123,
                Cidade = "São Paulo",
                Estado = "SP",
                Cep = "12345678" // Inválido: sem hífen
            };

            var result = ValidateModel(endereco);

            Assert.Contains(result, r => r.ErrorMessage!.Contains("format"));
        }
    }
}