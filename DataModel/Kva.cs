namespace _30_01_225.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kva")]
    public partial class Kva
    {
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(10)]
        public string Vladelec { get; set; }

        [StringLength(10)]
        public string Размер { get; set; }

        [StringLength(10)]
        public string Vozrast { get; set; }
    }
}
