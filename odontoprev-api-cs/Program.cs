using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.Repositories.Interface;
using odontoprev_api_cs.Repositories.Repository;
using odontoprev_api_cs.Services.Interfaces;
using odontoprev_api_cs.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQLConnection"));
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

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();