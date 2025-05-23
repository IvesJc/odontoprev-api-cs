using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using odontoprev_api_cs.Entities;
using Xunit;

public class BeneficiarioIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public BeneficiarioIntegrationTests(WebApplicationFactory<Microsoft.VisualStudio.TestPlatform.TestHost.Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task PostBeneficiario_DeveRetornarCreated()
    {
        var novoBeneficiario = new Beneficiario
        {
            Nome = "João da Silva",
            Password = "SenhaForte123!",
            Cpf = "123.456.789-00",
            Tipo = TipoBeneficiarioEnum.Pessoal,
            Telefone = "(11) 91234-5678",
            DataAdesao = DateTime.Now
        };

        var response = await _client.PostAsJsonAsync("/api/beneficiarios", novoBeneficiario);

        response.StatusCode.Should().Be(HttpStatusCode.Created);
        var location = response.Headers.Location.ToString();
        location.Should().Contain("/api/beneficiarios/");
    }

    [Fact]
    public async Task GetBeneficiarios_DeveRetornarOk()
    {
        var response = await _client.GetAsync("/api/beneficiarios");

        response.EnsureSuccessStatusCode();
        var lista = await response.Content.ReadFromJsonAsync<List<Beneficiario>>();
        lista.Should().NotBeNull();
    }
    
    [Fact]
    public async Task CriarEObterBeneficiario_Completo()
    {
        var novo = new Beneficiario
        {
            Nome = "Maria Teste",
            Password = "Senha123",
            Cpf = "111.222.333-44",
            Tipo = TipoBeneficiarioEnum.Pessoal,
            Telefone = "+55 (11) 98765-4321",
            DataAdesao = DateTime.UtcNow
        };

        // Criar beneficiário
        var postResponse = await _client.PostAsJsonAsync("/api/beneficiarios", novo);
        postResponse.EnsureSuccessStatusCode();
        var location = postResponse.Headers.Location;

        // Buscar o mesmo beneficiário
        var getResponse = await _client.GetAsync(location);
        getResponse.EnsureSuccessStatusCode();

        var beneficiarioCriado = await getResponse.Content.ReadFromJsonAsync<Beneficiario>();
        beneficiarioCriado.Should().NotBeNull();
        beneficiarioCriado!.Cpf.Should().Be(novo.Cpf);
    }
}