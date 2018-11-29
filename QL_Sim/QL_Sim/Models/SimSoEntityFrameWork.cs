namespace QL_Sim.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SimSoEntityFrameWork : DbContext
    {
        public SimSoEntityFrameWork()
            : base("name=SimSo")
        {
        }

        public virtual DbSet<SimSo> SimSo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SimSo>()
                .Property(e => e.so)
                .IsFixedLength();
        }
    }
}
