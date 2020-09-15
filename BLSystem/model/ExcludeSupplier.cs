using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLSystem
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public class ExcludeSupplier
    {
        [Key]
        public int id { get; set; }

        public int? RegNo { get; set; }

        public int RouteId { get; set; }
    }
}
