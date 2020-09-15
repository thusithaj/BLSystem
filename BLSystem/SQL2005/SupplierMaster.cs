namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierMaster")]
    public partial class SupplierMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierMaster()
        {
            RouteQties = new HashSet<RouteQty>();
            SupplierLedgers = new HashSet<SupplierLedger>();
        }

        public int id { get; set; }

        public int? FactoryId { get; set; }

        public int? RouteId { get; set; }

        public int RegNo { get; set; }

        public DateTime? RegDate { get; set; }

        public int? AddressBookId { get; set; }

        public int? WelfareRegistered { get; set; }

        [StringLength(10)]
        public string WelfareId { get; set; }

        public DateTime? WelfareRegDate { get; set; }

        public int? SavingRegistered { get; set; }

        public DateTime? SavingRegDate { get; set; }

        public DateTime? LastLeafDate { get; set; }

        public int? Status { get; set; }

        public decimal? Balance { get; set; }

        public int? Deleted { get; set; }

        [StringLength(10)]
        public string PayMode { get; set; }

        [StringLength(20)]
        public string BankAccount { get; set; }

        public int? BankId { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual AddressBook AddressBook { get; set; }

        public virtual AddressBook AddressBook1 { get; set; }

        public virtual FactoryMaster FactoryMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RouteQty> RouteQties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierLedger> SupplierLedgers { get; set; }
    }
}
