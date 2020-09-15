namespace BLSystem

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Collection_tbl
    {
        [Key]
        [Column(Order = 0)]
        public int ind { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short trDay { get; set; }

        [StringLength(10)]
        public string trMonth { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? trDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int regNo { get; set; }

        [StringLength(50)]
        public string Route { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal Qty { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Vehicale { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal trRate { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LeafType { get; set; }

        [StringLength(50)]
        public string Ws { get; set; }
    }
}
