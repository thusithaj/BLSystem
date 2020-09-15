namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExcludeSupplier")]
    public partial class ExcludeSupplier
    {
        public int id { get; set; }

        public int? RegNo { get; set; }

        public int? RouteId { get; set; }
    }
}
