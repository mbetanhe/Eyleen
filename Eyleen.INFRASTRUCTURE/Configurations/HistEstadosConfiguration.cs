using Eyleen.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eyleen.INFRASTRUCTURE.Configurations
{
    public class HistEstadosConfiguration : IEntityTypeConfiguration<HistEstados>
    {
        public void Configure(EntityTypeBuilder<HistEstados> entity)
        {
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.ClienteId).HasColumnName("Cliente_ID");

            entity.Property(e => e.EstadoId).HasColumnName("Estado_ID");

            entity.Property(e => e.FechaCreacion)
                .HasColumnName("Fecha_Creacion")
                .HasColumnType("datetime");

            entity.Property(e => e.Observacion).IsRequired();
        }
    }
}
