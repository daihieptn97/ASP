namespace Mau2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SimSoEntityFrameword : DbContext
    {
        public SimSoEntityFrameword()
            : base("name=SimSo")
        {
        }

        public virtual DbSet<SoDienThoai> sodienthoais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoDienThoai>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<SoDienThoai>()
                .Property(e => e.so)
                .IsFixedLength();
        }
    }
}
