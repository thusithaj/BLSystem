namespace BLSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkCenterMaster")]
    public partial class WorkCenterMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkCenterMaster()
        {
            TeamMasters = new HashSet<TeamMaster>();
        }

        public int id { get; set; }

        public int? FactoryId { get; set; }

        [StringLength(100)]
        public string WorkSection { get; set; }

        public virtual Factory Factory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamMaster> TeamMasters { get; set; }
    }
}
