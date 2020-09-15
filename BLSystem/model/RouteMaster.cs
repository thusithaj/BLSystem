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
    [Table("RouteMaster")]
    public partial class RouteMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RouteMaster()
        {

        }
        [Key]
        public int ind { get; set; }

        [StringLength(3)]
        public string rCode { get; set; }

        [StringLength(50)]
        public string rName { get; set; }

        public decimal trRate { get; set; }

        public decimal blRate { get; set; }
        public decimal newBlRate { get; set; }
        public decimal Incentive { get; set; }
        public decimal blRateSL { get; set; }
        public decimal newBlRateSL { get; set; }
        public decimal Target { get; set; }
        public bool? trActive { get; set; }
        public decimal DdRate { get; set; }
        public decimal ExtraRate { get; set; }
        public int? RouteID { get; set; }
        public int? AreaID { get; set; }
    }
}
