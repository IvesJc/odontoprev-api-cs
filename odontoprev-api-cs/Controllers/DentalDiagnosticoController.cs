using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace odontoprev_api_cs.Controllers;

[Route("api/dentalDiagnostico")]
[ApiController]
[Authorize]
public class DentalDiagnosticoController : ControllerBase
{
    [HttpPost("analise-imagem")]
    public async Task<IActionResult> AnaliseImagem(IFormFile imagem)
    {
        var httpClient = new HttpClient();
    
        using var ms = new MemoryStream();
        await imagem.CopyToAsync(ms);
        var byteArray = ms.ToArray();
    
        httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "C5Bjl6ld3GrNtmKIo8Y5mXm3N0BvNp2gn6239LfVlKyr1mijCD8CJQQJ99BEACHYHv6XJ3w3AAAAACOGr0ER");
        httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Region", "eastus2");
    
        var content = new ByteArrayContent(byteArray);
        content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
    
        var response = await httpClient.PostAsync("https://mr553-mazjzry9-eastus2.cognitiveservices.azure.com/vision/v3.2/analyze?visualFeatures=Description", content);
        var result = await response.Content.ReadAsStringAsync();
    
        return Ok(result);
    }
}