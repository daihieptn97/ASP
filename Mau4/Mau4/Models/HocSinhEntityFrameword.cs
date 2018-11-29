namespace Mau4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HocSinhEntityFrameword : DbContext
    {
        public HocSinhEntityFrameword()
            : base("name=HocSinh")
        {
        }

        public virtual DbSet<sinhvien> sinhvien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sinhvien>()
                .Property(e => e.name)
                .IsFixedLength();
        }
    }
}
