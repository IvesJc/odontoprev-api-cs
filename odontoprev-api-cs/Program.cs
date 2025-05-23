using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Repositories.Repository;
using odontoprev_api_cs.Services.Interfaces;
using odontoprev_api_cs.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("OracleSQLConnection"));
});

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 12;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
}).AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
        options.DefaultChallengeScheme =
            options.DefaultForbidScheme =
                options.DefaultScheme =
                    options.DefaultSignInScheme =
                        options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:Audience"],
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            System.Text.Encoding.UTF8.GetBytes(builder.Configuration["JWT:SigningKey"]))
    };
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddControllers().AddJsonOptions(options =>
// {
//     options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
// });

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "OdontoPrev API - Adaptive Dialogs",
        Version = "v1",
        Description = "API desenvolvida para o projeto Adaptive Dialogs da OdontoPrev.",
        License = new OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://opensource.org/licenses/MIT")
        }
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });

    // Adiciona os integrantes do grupo como tags no Swagger
    options.DocumentFilter<SwaggerGrupoFilter>();
});

builder.Services.AddControllers()
    .AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });

builder.Services.AddScoped<IBeneficiarioRepository, BeneficiarioRepository>();
builder.Services.AddScoped<IEmpresaContratanteRepository, EmpresaContratanteRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IMissaoRepository, MissaoRepository>();
builder.Services.AddScoped<IPlanoRepository, PlanoRepository>();
builder.Services.AddScoped<IPrestadorServicoRepository, PrestadorServicoRepository>();
builder.Services.AddScoped<IProgramaRelacionamentoStatusRepository, ProgramaRelacionamentoStatusRepository>();
builder.Services.AddScoped<IRecompensaRepository, RecompensaRepository>();
builder.Services.AddScoped<IRedeCredenciadaRepository, RedeCredenciadaRepository>();
builder.Services.AddScoped<IServicoRepository, ServicoRepository>();
builder.Services.AddScoped<ISinistroRepository, SinistroRepository>();
builder.Services.AddScoped<ITipoMissaoRepository, TipoMissaoRepository>();
builder.Services.AddScoped<ITipoPlanoRepository, TipoPlanoRepository>();
builder.Services.AddScoped<ITipoRecompensaRepository, TipoRecompensaRepository>();
builder.Services.AddScoped<ITipoServicoRepository, TipoServicoRepository>();

builder.Services.AddScoped<IBeneficiarioService, BeneficiarioService>();
builder.Services.AddScoped<IEmpresaContratanteService, EmpresaContratanteService>();
builder.Services.AddScoped<IEnderecoService, EnderecoService>();
builder.Services.AddScoped<IMissaoService, MissaoService>();
builder.Services.AddScoped<IPlanoService, PlanoService>();
builder.Services.AddScoped<IPrestadorServicoService, PrestadorServicoService>();
builder.Services.AddScoped<IProgramaRelacionamentoStatusService, ProgramaRelacionamentoStatusService>();
builder.Services.AddScoped<IRecompensaService, RecompensaService>();
builder.Services.AddScoped<IRedeCredenciadaService, RedeCredenciadaService>();
builder.Services.AddScoped<IServicoService, ServicoService>();
builder.Services.AddScoped<ISinistroService, SinistroService>();
builder.Services.AddScoped<ITipoMissaoService, TipoMissaoService>();
builder.Services.AddScoped<ITipoPlanoService, TipoPlanoService>();
builder.Services.AddScoped<ITipoRecompensaService, TipoRecompensaService>();
builder.Services.AddScoped<ITipoServicoService, TipoServicoService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IDentalDiagnosticoService, DentalDiagnosticoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "OdontoPrev API - Adaptive Dialogs V1");
        options.DocumentTitle = "OdontoPrev API - Adaptive Dialogs";
    });
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();