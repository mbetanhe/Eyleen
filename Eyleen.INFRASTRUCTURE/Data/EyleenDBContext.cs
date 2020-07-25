using Eyleen.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Eyleen.INFRASTRUCTURE.Data
{
    public partial class EyleenDBContext : DbContext
    {
        public EyleenDBContext()
        {
        }

        public EyleenDBContext(DbContextOptions<EyleenDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DimEstados> DimEstados { get; set; }
        public virtual DbSet<DimModulos> DimModulos { get; set; }
        public virtual DbSet<HistEstados> HistEstados { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
       
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Obtenemos todas las configuraciones de /Configurations
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
