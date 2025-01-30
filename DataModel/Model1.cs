using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _30_01_225.DataModel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Kva> Kva { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kva>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Kva>()
                .Property(e => e.Vladelec)
                .IsFixedLength();

            modelBuilder.Entity<Kva>()
                .Property(e => e.Размер)
                .IsFixedLength();

            modelBuilder.Entity<Kva>()
                .Property(e => e.Vozrast)
                .IsFixedLength();
        }
    }
}
