namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamMaster")]
    public partial class TeamMaster
    {
        public int id { get; set; }

        public int? WorkCenterid { get; set; }

        [StringLength(100)]
        public string TeamName { get; set; }

        public virtual WorkCenterMaster WorkCenterMaster { get; set; }
    }
}
