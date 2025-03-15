﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using odontoprev_api_cs.Data.AppData;

#nullable disable

namespace odontoprev_api_cs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250315123555_Fix entity names")]
    partial class Fixentitynames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("odontoprev_api_cs.Entities.BeneficiarioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataAdesao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EmpresaContratanteId")
                        .HasColumnType("integer");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("integer");

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("NumeroContrato")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Tipo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_beneficiario");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.EmpresaContratanteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("NumeroContrato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("tb_empresa_contratante");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.EnderecoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("tb_endereco");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.MissaoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiarioId")
                        .HasColumnType("integer");

                    b.Property<int>("Concluido")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpiraEm")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RecompensaRecebida")
                        .HasColumnType("integer");

                    b.Property<int>("TipoMissaoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_missao");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.PlanoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DataFinalCarencia")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EmpresaContratanteId")
                        .HasColumnType("integer");

                    b.Property<double>("PrecoCobrado")
                        .HasColumnType("double precision");

                    b.Property<int>("TipoPlanoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_plano");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.PrestadorServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Avaliacao")
                        .HasColumnType("integer");

                    b.Property<int>("Especialidade")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("NumeroContrato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("NumeroCro")
                        .HasColumnType("integer");

                    b.Property<int>("RedeCredenciadaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_prestador_servico");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.ProgramaRelacionamentoStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiarioId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataAdesao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("QtdePontos")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_programa_relacionamento_status");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.RecompensaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiarioId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpiraEm")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ResgatadoEm")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TipoRecompensaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_recompensa");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.RedeCredenciadaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("tb_rede_credenciada");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.ServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("SinistroId")
                        .HasColumnType("integer");

                    b.Property<int>("TipoServicoId")
                        .HasColumnType("integer");

                    b.Property<double>("ValorPago")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("tb_servico");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.SinistroEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiarioId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataAutorizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataSolicitacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PrestadorServicoId")
                        .HasColumnType("integer");

                    b.Property<double?>("ValorPagoParaPrestador")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("tb_sinistro");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.TipoMissaoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DuracaoPadraoDias")
                        .HasColumnType("integer");

                    b.Property<int>("Frequencia")
                        .HasColumnType("integer");

                    b.Property<int>("RecompensaPadrao")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_missao");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.TipoPlanoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarenciaDias")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("double precision");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ValidadeDias")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_plano");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.TipoRecompensaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Aplicacao")
                        .HasColumnType("integer");

                    b.Property<int>("ExpiracaoDias")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_recompensa");
                });

            modelBuilder.Entity("odontoprev_api_cs.Entities.TipoServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("ValorReais")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_servico");
                });
#pragma warning restore 612, 618
        }
    }
}
