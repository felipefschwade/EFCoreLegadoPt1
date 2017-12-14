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
    class AtorConfiguration : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> modelBuilder)
        {
            modelBuilder
                .ToTable("actor");

            modelBuilder
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            modelBuilder
                .Property(a => a.PrimeiroNome)
                .HasColumnType("varchar(45)")
                .HasColumnName("first_name")
                .IsRequired();

            modelBuilder
               .Property(a => a.UltimoNome)
               .HasColumnType("varchar(45)")
               .HasColumnName("last_name")
               .IsRequired();

            modelBuilder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
