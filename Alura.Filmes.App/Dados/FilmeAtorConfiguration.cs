using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            builder.ToTable("film_actor");


            builder
                .Property<int>("actor_id");

            builder
                .Property<int>("film_id");

            builder.HasKey("actor_id", "film_id");

            builder
               .Property<DateTime>("last_update")
               .HasColumnType("datetime")
               .HasDefaultValueSql("getdate()");

            builder
                .HasOne(fa => fa.Filme)
                .WithMany(f => f.Atores)
                .HasForeignKey("actor_id");

            builder
                .HasOne(fa => fa.Ator)
                .WithMany(a => a.Filmes)
                .HasForeignKey("film_id");
        }
    }
}
