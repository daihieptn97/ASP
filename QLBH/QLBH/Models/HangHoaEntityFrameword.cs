namespace QLBH.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HangHoaEntityFrameword : DbContext
    {
        public HangHoaEntityFrameword()
            : base("name=HangHoa")
        {
        }

        public virtual DbSet<HangHoa> hanghoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.name)
                .IsFixedLength();
        }
    }
}
