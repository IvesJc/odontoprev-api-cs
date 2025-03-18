using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace odontoprev_api_cs.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_beneficiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Tipo = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataAdesao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    FotoUrl = table.Column<string>(type: "NVARCHAR2(300)", maxLength: 300, nullable: true),
                    NumeroContrato = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    EnderecoId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EmpresaContratanteId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_beneficiario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_empresa_contratante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Cnpj = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NumeroContrato = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_empresa_contratante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Rua = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Numero = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Cep = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
                    Complemento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_missao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Concluido = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    RecompensaRecebida = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ExpiraEm = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TipoMissaoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    BeneficiarioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_missao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_plano",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataExpiracao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    PrecoCobrado = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    DataFinalCarencia = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    TipoPlanoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EmpresaContratanteId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_prestador_servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NumeroCro = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Especialidade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NumeroContrato = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Avaliacao = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    RedeCredenciadaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_prestador_servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_programa_relacionamento_status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    QtdePontos = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataAdesao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    BeneficiarioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_programa_relacionamento_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_recompensa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ResgatadoEm = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ExpiraEm = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    BeneficiarioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TipoRecompensaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_recompensa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rede_credenciada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rede_credenciada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ValorPago = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    TipoServicoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SinistroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_sinistro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataSolicitacao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DataAutorizacao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ValorPagoParaPrestador = table.Column<double>(type: "BINARY_DOUBLE", nullable: true),
                    BeneficiarioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PrestadorServicoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sinistro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_missao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Titulo = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    DuracaoPadraoDias = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    RecompensaPadrao = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Frequencia = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipo_missao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_plano",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Preco = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    CarenciaDias = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ValidadeDias = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipo_plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_recompensa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    ExpiracaoDias = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Aplicacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipo_recompensa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tipo_servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    ValorReais = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
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
