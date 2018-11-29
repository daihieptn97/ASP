namespace QL_Sim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sim")]
    public partial class SimSo
    {
        public int id { get; set; }

        [Required]
        [StringLength(11)]
        public string so { get; set; }

        [Required]

        public int gia { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaynhap { get; set; }
    }
}
