namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RouteMaster")]
    public partial class RouteMaster
    {
        [Key]
        public int ind { get; set; }

        [Required]
        [StringLength(3)]
        public string rCode { get; set; }

        [Required]
        [StringLength(50)]
        public string rName { get; set; }

        [Column(TypeName = "money")]
        public decimal trRate { get; set; }

        [Column(TypeName = "money")]
        public decimal blRate { get; set; }

        [Column(TypeName = "money")]
        public decimal newBlRate { get; set; }

        [Column(TypeName = "money")]
        public decimal Incentive { get; set; }

        [Column(TypeName = "money")]
        public decimal blRateSL { get; set; }

        [Column(TypeName = "money")]
        public decimal newBlRateSL { get; set; }

        [Column(TypeName = "money")]
        public decimal Target { get; set; }

        public bool trActive { get; set; }

        [Column(TypeName = "money")]
        public decimal DdRate { get; set; }

        [Column(TypeName = "money")]
        public decimal ExtraRate { get; set; }

        public int? RouteID { get; set; }

        public int? AreaID { get; set; }
    }
}
