namespace BLSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RouteQty")]
    public partial class RouteQty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RouteQty()
        {
            SupplierLedgers = new HashSet<SupplierLedger>();
        }

        public int id { get; set; }

        public int? RouteId { get; set; }

        public int? SupplierId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Trndate { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? GrossAmt { get; set; }

        public decimal? DeductAmt { get; set; }

        public decimal? BalanceAmt { get; set; }

        public int? ProductId { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? Modifieddate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierLedger> SupplierLedgers { get; set; }
    }
}
