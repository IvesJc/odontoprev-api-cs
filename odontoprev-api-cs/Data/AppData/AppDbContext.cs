using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Data.AppData;

public class AppDbContext : IdentityDbContext<ApplicationUser>
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

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        List<IdentityRole> roles = new List<IdentityRole>
        {
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER"
            }
        };
        modelBuilder.Entity<IdentityRole>().HasData(roles);

        // 🔧 Aqui você força todos os bools a virarem NUMBER(1) no Oracle
        modelBuilder
            .Model
            .GetEntityTypes()
            .SelectMany(e => e.GetProperties())
            .Where(p => p.ClrType == typeof(bool))
            .ToList()
            .ForEach(p => p.SetColumnType("NUMBER(1)"));
    }
}