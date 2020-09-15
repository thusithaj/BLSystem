namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressBookType")]
    public partial class AddressBookType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AddressBookType()
        {
            AddressBooks = new HashSet<AddressBook>();
        }

        public int id { get; set; }

        public int? CompanyId { get; set; }

        [StringLength(100)]
        public string BookTypeName { get; set; }

        [StringLength(10)]
        public string Category01 { get; set; }

        [StringLength(10)]
        public string Category02 { get; set; }

        [StringLength(10)]
        public string Category03 { get; set; }

        [StringLength(10)]
        public string Category04 { get; set; }

        [StringLength(10)]
        public string Category05 { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddressBook> AddressBooks { get; set; }

        public virtual CompanyMaster CompanyMaster { get; set; }
    }
}
