using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1Store.Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace H1Store.Catalogo.Data.EntityFramework
{
    public class CartaConfiguration : IEntityTypeConfiguration<Carta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Carta> builder)
        {
            builder.ToTable("CARTAS_NATALINAS");
            builder.HasKey(t => t.Id);

            builder
                .Property(t => t.Id)
                .UseIdentityColumn()
                .HasColumnName("CARTAS_ID")
                .HasColumnType("INT");

            builder
                .Property(t => t.NomeCrianca)
                .HasColumnName("NOME_CRIANCA")
                .HasColumnType("VARCHAR(200)");

            builder
                .Property(t => t.Idade)
                .HasColumnName("IDADE")
                .HasColumnType("INT");

            builder
                .Property(t => t.Rua)
                .HasColumnName("RUA")
                .HasColumnType("VARCHAR(100)");

            builder
                .Property(t => t.Bairro)
                .HasColumnName("BAIRRO")
                .HasColumnType("VARCHAR(100)");

            builder
                .Property(t => t.Cidade)
                .HasColumnName("CIDADE")
                .HasColumnType("VARCHAR(100)");

            builder
                .Property(t => t.Estado)
                .HasColumnName("ESTADO")
                .HasColumnType("VARCHAR(100)");

            builder
                .Property(t => t.Numero)
                .HasColumnName("NUMERO")
                .HasColumnType("INT");

            builder
                .Property(t => t.TextoCarta)
                .HasColumnName("TEXTO_CARTA")
                .HasColumnType("VARCHAR(100)");
        }
    }
}
