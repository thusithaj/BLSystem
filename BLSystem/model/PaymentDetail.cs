namespace BLSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentDetail")]
    public partial class PaymentDetail
    {
        public int id { get; set; }

        public int? PaymentId { get; set; }

        public int? ProductId { get; set; }

        public decimal? CostPrice { get; set; }

        public decimal? CostQty { get; set; }

        public decimal? TotalCost { get; set; }

        public decimal? SoldPrice { get; set; }

        public decimal? SoldQty { get; set; }

        public decimal? SoldAmount { get; set; }

        public virtual PaymentMaster PaymentMaster { get; set; }

        public virtual Product Product { get; set; }
    }
}
