using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

public class SwaggerGrupoFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        swaggerDoc.Tags = new List<OpenApiTag>
        {
            new OpenApiTag { Name = "Integrantes", Description = "Equipe do projeto OdontoPrev API - Adaptive Dialogs" },
            new OpenApiTag { Name = "Ellie de Oliveira", Description = "RM: 552824" },
            new OpenApiTag { Name = "Ives Jundi Chiba", Description = "RM: 553243" },
            new OpenApiTag { Name = "Nathalia Comeron Freire", Description = "RM: 553233" },
        };
    }
}