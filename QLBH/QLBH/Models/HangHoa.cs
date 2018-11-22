namespace QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hanghoa")]
    public partial class HangHoa
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên trước khi thêm")]
        [StringLength(255)]
        public string name { get; set; }




        [Required(ErrorMessage = "Vui lòng nhập ngày hết hạn trước khi thêm")]
        [Column(TypeName = "date")]
        public DateTime expired { get; set; }

        [Range(0, 1000000, ErrorMessage = "Vui lòng nhập số lượng trong khoảng 0 đến 1000000")]
        [Required(ErrorMessage = "Vui lòng nhập số lượng trước khi thêm")]
        public int total { get; set; }
    }
}
