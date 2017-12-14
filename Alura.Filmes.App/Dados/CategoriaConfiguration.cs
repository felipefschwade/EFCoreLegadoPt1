using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("category");

            builder
               .Property(f => f.Id)
               .HasColumnName("category_id");

            builder
                .Property(f => f.Nome)
                .HasColumnName("name")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
               .Property<DateTime>("last_update")
               .HasColumnType("datetime")
               .HasDefaultValueSql("getdate()");
        }
    }
}
