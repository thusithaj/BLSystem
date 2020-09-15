namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentMaster")]
    public partial class PaymentMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentMaster()
        {
            PaymentDetails = new HashSet<PaymentDetail>();
        }

        public int id { get; set; }

        public int? AddressId { get; set; }

        public DateTime? TrnDate { get; set; }

        [StringLength(10)]
        public string RefNo { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        public decimal? Amount { get; set; }

        public decimal? PaidAmount { get; set; }

        public decimal? BalanceAmt { get; set; }

        public int? SettledFlag { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? Createddate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? Modifieddate { get; set; }

        public virtual AddressBook AddressBook { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}
