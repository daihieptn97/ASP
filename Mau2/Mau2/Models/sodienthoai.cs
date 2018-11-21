namespace Mau2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sodienthoai")]
    public partial class SoDienThoai
    {
        [Required(ErrorMessage = "vui long nhap ID")]
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(10)]
        public string so { get; set; }

        [Range(0, 5000000)]
        [Required(ErrorMessage = "vui long nhap gia")]
        public int gia { get; set; }

        [Required(ErrorMessage = "vui long chon ngay")]
        [Column(TypeName = "date")]
        public DateTime ngay { get; set; }
    }
}
