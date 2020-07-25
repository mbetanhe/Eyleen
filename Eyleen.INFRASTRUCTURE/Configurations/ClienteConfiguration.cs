using Eyleen.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eyleen.INFRASTRUCTURE.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Apellidos)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Celular)
                .IsRequired()
                .HasMaxLength(12);

            entity.Property(e => e.Comentarios).IsRequired();

            entity.Property(e => e.Departamento)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Dirección).IsRequired();

            entity.Property(e => e.FechaCreacion)
                .HasColumnName("Fecha_Creacion")
                .HasColumnType("datetime");

            entity.Property(e => e.FechaModificacion)
                .HasColumnName("Fecha_Modificacion")
                .HasColumnType("datetime");

            entity.Property(e => e.Identificacion)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.Municipio)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
