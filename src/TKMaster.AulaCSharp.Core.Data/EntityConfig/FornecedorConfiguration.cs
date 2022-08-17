using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TKMaster.AulaCSharp.Core.Domain.Entities;

namespace TKMaster.AulaCSharp.Core.Data.EntityConfig
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("fornecedor", "dbo");

            builder
                .Property(f => f.Codigo)
                .HasColumnName("id");

            builder
                .HasKey(f => f.Codigo);

            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasColumnName("nome");

            builder
                .Property(f => f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("documento");

            builder
                .Property(c => c.TipoPessoa)
                .HasMaxLength(1)
                .HasColumnName("tipo_pessoa");

            builder
                .Property(p => p.Status)
                .IsRequired()
                .HasColumnName("status");

            builder
                .Property(c => c.DataCadastro)
                .IsRequired()
                .HasColumnName("dt_inclusao");

            builder
                .Property(c => c.DataAlteracao)
                .HasColumnName("dt_alteracao");

            builder
                .Property(c => c.DataExclusao)
                .HasColumnName("dt_exclusao");
        }
    }
}
