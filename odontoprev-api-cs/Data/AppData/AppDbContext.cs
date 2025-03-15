using Microsoft.EntityFrameworkCore;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Data.AppData;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<BeneficiarioEntity> Beneficiario { get; set; }
    public DbSet<EmpresaContratanteEntity> EmpresaContratante { get; set; }
    public DbSet<EnderecoEntity> Endereco { get; set; }
    public DbSet<MissaoEntity> Missao { get; set; }
    public DbSet<PlanoEntity> Plano { get; set; }
    public DbSet<PrestadorServicoEntity> PrestadorServico { get; set; }
    public DbSet<ProgramaRelacionamentoStatusEntity> ProgramaRelacionamentoStatus { get; set; }
    public DbSet<RecompensaEntity> Recompensa { get; set; }
    public DbSet<RedeCredenciadaEntity> RedeCredenciada { get; set; }
    public DbSet<ServicoEntity> Servico { get; set; }
    public DbSet<SinistroEntity> Sinistro { get; set; }
    public DbSet<TipoMissaoEntity> TipoMissao { get; set; }
    public DbSet<TipoPlanoEntity> TipoPlano { get; set; }
    public DbSet<TipoRecompensaEntity> TipoRecompensa { get; set; }
    public DbSet<TipoServicoEntity> TipoServico { get; set; }
    
}