using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace odontoprev_api_cs.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_beneficiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<int>(type: "integer", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    DataAdesao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FotoUrl = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    NumeroContrato = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    EnderecoId = table.Column<int>(type: "integer", nullable: true),
                    EmpresaContratanteId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_beneficiario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_empresa_contratante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Cnpj = table.Column<string>(type: "text", nullable: false),
                    NumeroContrato = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_empresa_contratante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rua = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Numero = table.Column<int>(type: "integer", nullable: false),
                    Cidade = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Estado = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Cep = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_missao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Concluido = table.Column<int>(type: "integer", nullable: false),
                    RecompensaRecebida = table.Column<int>(type: "integer", nullable: false),
                    ExpiraEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TipoMissaoId = table.Column<int>(type: "integer", nullable: false),
                    BeneficiarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_missao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_plano",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataExpiracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PrecoCobrado = table.Column<double>(type: "double precision", nullable: false),
                    DataFinalCarencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TipoPlanoId = table.Column<int>(type: "integer", nullable: false),
                    EmpresaContratanteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_prestador_servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NumeroCro = table.Column<int>(type: "integer", nullable: false),
                    Especialidade = table.Column<int>(type: "integer", nullable: false),
                    NumeroContrato = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Avaliacao = table.Column<int>(type: "integer", nullable: true),
                    RedeCredenciadaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_prestador_servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_programa_relacionamento_status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QtdePontos = table.Column<int>(type: "integer", nullable: false),
                    DataAdesao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BeneficiarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_programa_relacionamento_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_recompensa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ResgatadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpiraEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BeneficiarioId = table.Column<int>(type: "integer", nullable: false),
                    TipoRecompensaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_recompensa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rede_credenciada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rede_credenciada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValorPago = table.Column<double>(type: "double precision", nullable: false),
                    TipoServicoId = table.Column<int>(type: "integer", nullable: false),
                    SinistroId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_sinistro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataSolicitacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataAutorizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ValorPagoParaPrestador = table.Column<double>(type: "double precision", nullable: true),
                    BeneficiarioId = table.Column<int>(type: "integer", nullable: false),
                    PrestadorServicoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sinistro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_missao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DuracaoPadraoDias = table.Column<int>(type: "integer", nullable: false),
                    RecompensaPadrao = table.Column<int>(type: "integer", nullable: false),
                    Frequencia = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipo_missao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_plano",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Preco = table.Column<double>(type: "double precision", nullable: false),
                    CarenciaDias = table.Column<int>(type: "integer", nullable: false),
                    ValidadeDias = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipo_plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_recompensa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ExpiracaoDias = table.Column<int>(type: "integer", nullable: false),
                    Aplicacao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipo_recompensa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ValorReais = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipo_servico", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_beneficiario");

            migrationBuilder.DropTable(
                name: "tb_empresa_contratante");

            migrationBuilder.DropTable(
                name: "tb_endereco");

            migrationBuilder.DropTable(
                name: "tb_missao");

            migrationBuilder.DropTable(
                name: "tb_plano");

            migrationBuilder.DropTable(
                name: "tb_prestador_servico");

            migrationBuilder.DropTable(
                name: "tb_programa_relacionamento_status");

            migrationBuilder.DropTable(
                name: "tb_recompensa");

            migrationBuilder.DropTable(
                name: "tb_rede_credenciada");

            migrationBuilder.DropTable(
                name: "tb_servico");

            migrationBuilder.DropTable(
                name: "tb_sinistro");

            migrationBuilder.DropTable(
                name: "tb_tipo_missao");

            migrationBuilder.DropTable(
                name: "tb_tipo_plano");

            migrationBuilder.DropTable(
                name: "tb_tipo_recompensa");

            migrationBuilder.DropTable(
                name: "tb_tipo_servico");
        }
    }
}
