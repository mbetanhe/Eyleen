using Eyleen.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Eyleen.INFRASTRUCTURE.Configurations
{
    public class DimModulosConfiguration : IEntityTypeConfiguration<DimModulos>
    {
        public void Configure(EntityTypeBuilder<DimModulos> entity)
        {
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.FechaCreacion)
                .HasColumnName("Fecha_Creacion")
                .HasColumnType("datetime");
        }
    }
}
