using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    class CategoriaFilmeConfiguration : IEntityTypeConfiguration<FilmeCategoria>
    {
        public void Configure(EntityTypeBuilder<FilmeCategoria> builder)
        {
            builder.ToTable("film_category");

            builder.Property<int>("film_id");
            builder.Property<byte>("category_id");

            builder
               .Property<DateTime>("last_update")
               .HasColumnType("datetime")
               .HasDefaultValueSql("getdate()");

            builder.HasKey("film_id", "category_id");

            builder
                .HasOne(x => x.Categoria)
                .WithMany(c => c.Filmes)
                .HasForeignKey("category_id");

            builder
                .HasOne(x => x.Filme)
                .WithMany(c => c.Categorias)
                .HasForeignKey("film_id");
        }
    }
}
