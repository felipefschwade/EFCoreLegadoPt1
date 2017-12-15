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
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {

           builder
                .ToTable("film");

           builder
                .Property(f => f.Id)
                .HasColumnName("film_id");

           builder
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property<byte>("language_id");

            builder
                .Property<byte?>("original_language_id");

            builder
                .HasOne(f => f.IdiomaFalado)
                .WithMany(i => i.FilmesFalados)
                .HasForeignKey("language_id");

            builder
                .HasOne(f => f.IdiomaOriginal)
                .WithMany(i => i.FilmesOriginais)
                .HasForeignKey("original_language_id");

            builder
                .Property(f => f.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");

           builder
                .Property(f => f.AnoLancamento)
                .HasColumnType("varchar(4)")
                .HasColumnName("release_year");

           builder
                .Property(f => f.Duracao)
                .HasColumnType("smallint")
                .HasColumnName("length");

           builder
                .Property(f => f.Avaliacao)
                .HasColumnType("varchar(10)")
                .HasDefaultValue("G")
                .HasColumnName("rating");

           builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

        }
    }
}
