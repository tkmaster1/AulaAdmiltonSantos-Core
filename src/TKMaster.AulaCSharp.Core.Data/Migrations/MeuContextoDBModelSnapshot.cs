// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TKMaster.AulaCSharp.Core.Data.Context;

#nullable disable

namespace TKMaster.AulaCSharp.Core.Data.Migrations
{
    [DbContext(typeof(MeuContextoDB))]
    partial class MeuContextoDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TKMaster.AulaCSharp.Core.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_inclusao");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_exclusao");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("documento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("tipo_pessoa");

                    b.HasKey("Codigo");

                    b.ToTable("fornecedor", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
