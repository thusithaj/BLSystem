namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FiscalPeriod")]
    public partial class FiscalPeriod
    {
        public int id { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? Todate { get; set; }

        public int? Status { get; set; }
    }
}
