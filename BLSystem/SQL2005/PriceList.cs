namespace BLSystem.SQL2005
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceList")]
    public partial class PriceList
    {
        public int id { get; set; }

        public int? PriceListType { get; set; }

        public int? ProductId { get; set; }

        public int? PartnerId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public DateTime? EffectFrom { get; set; }

        public DateTime? EffectTo { get; set; }

        public int? Status { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual AddressBook AddressBook { get; set; }

        public virtual PriceListType PriceListType1 { get; set; }

        public virtual Product Product { get; set; }
    }
}
