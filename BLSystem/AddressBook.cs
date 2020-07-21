namespace BLSystem
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
            SupplierLedgers = new HashSet<SupplierLedger>();
            SupplierLedgers1 = new HashSet<SupplierLedger>();
            SupplierMasters = new HashSet<SupplierMaster>();
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

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual AddressBookType AddressBookType { get; set; }

        public virtual Factory Factory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierLedger> SupplierLedgers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierLedger> SupplierLedgers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierMaster> SupplierMasters { get; set; }
    }
}
