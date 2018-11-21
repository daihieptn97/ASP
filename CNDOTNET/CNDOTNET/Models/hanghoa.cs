namespace CNDOTNET.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hanghoa")]
    public partial class HangHoa
    {
        [StringLength(50)]
        public string id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        public DateTime expired { get; set; }

        public int total { get; set; }
    }
}
