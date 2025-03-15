using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Data.AppData;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Beneficiario> Beneficiario { get; set; }
    public DbSet<EmpresaContratante> EmpresaContratante { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<Missao> Missao { get; set; }
    public DbSet<Plano> Plano { get; set; }
    public DbSet<PrestadorServico> PrestadorServico { get; set; }
    public DbSet<ProgramaRelacionamentoStatus> ProgramaRelacionamentoStatus { get; set; }
    public DbSet<Recompensa> Recompensa { get; set; }
    public DbSet<RedeCredenciada> RedeCredenciada { get; set; }
    public DbSet<Servico> Servico { get; set; }
    public DbSet<Sinistro> Sinistro { get; set; }
    public DbSet<TipoMissao> TipoMissao { get; set; }
    public DbSet<TipoPlano> TipoPlano { get; set; }
    public DbSet<TipoRecompensa> TipoRecompensa { get; set; }
    public DbSet<TipoServico> TipoServico { get; set; }
    
}