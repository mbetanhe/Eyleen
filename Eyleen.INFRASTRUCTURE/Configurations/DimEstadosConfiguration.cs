using Eyleen.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eyleen.INFRASTRUCTURE.Configurations
{
    public class DimEstadosConfiguration : IEntityTypeConfiguration<DimEstados>
    {
        public void Configure(EntityTypeBuilder<DimEstados> entity)
        {

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.FechaCreacion)
                .HasColumnName("Fecha_Creacion")
                .HasColumnType("datetime");
        }
    }
}
