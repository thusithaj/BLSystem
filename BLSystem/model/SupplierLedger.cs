namespace BLSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierLedger")]
    public partial class SupplierLedger
    {
        public int id { get; set; }

        public int RouteId { get; set; }

        public int SupplierId { get; set; }

        public int ProductId { get; set; }

        public int? RelatedFactory { get; set; }

        [Column(TypeName = "date")]
        public DateTime TrnDate { get; set; }

        public decimal Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        public int? ExtraId { get; set; }

        [StringLength(50)]
        public string Ref01 { get; set; }

        [StringLength(50)]
        public string Ref02 { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual AddressBook AddressBook { get; set; }

        public virtual AddressBook AddressBook1 { get; set; }

        public virtual Product Product { get; set; }

        public virtual RouteQty RouteQty { get; set; }

        public virtual SupplierMaster SupplierMaster { get; set; }
    }
}
