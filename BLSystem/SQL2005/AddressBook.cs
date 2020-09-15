namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressBook")]
    public partial class AddressBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AddressBook()
        {
            PaymentMasters = new HashSet<PaymentMaster>();
            PriceLists = new HashSet<PriceList>();
            SupplierLedgers = new HashSet<SupplierLedger>();
            SupplierLedgers1 = new HashSet<SupplierLedger>();
            SupplierMasters = new HashSet<SupplierMaster>();
            SupplierMasters1 = new HashSet<SupplierMaster>();
        }

        public int id { get; set; }

        public int? FactoryId { get; set; }

        public int? AddressType { get; set; }

        [StringLength(100)]
        public string AddressName { get; set; }

        [StringLength(100)]
        public string AddressLine01 { get; set; }

        [StringLength(100)]
        public string AddressLine02 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(20)]
        public string TP01 { get; set; }

        [StringLength(20)]
        public string TP02 { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual AddressBookType AddressBookType { get; set; }

        public virtual FactoryMaster FactoryMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentMaster> PaymentMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceList> PriceLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierLedger> SupplierLedgers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierLedger> SupplierLedgers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierMaster> SupplierMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierMaster> SupplierMasters1 { get; set; }
    }
}
