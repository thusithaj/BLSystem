namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewPartnerLedger")]
    public partial class ViewPartnerLedger
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegNo { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? GrossAmt { get; set; }

        public decimal? DeductAmt { get; set; }

        public decimal? BalanceAmt { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(10)]
        public string TransactionType { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime TrnDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Expr1 { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(50)]
        public string Ref01 { get; set; }

        [StringLength(50)]
        public string Ref02 { get; set; }

        [StringLength(100)]
        public string AddressName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RouteId { get; set; }
    }
}
