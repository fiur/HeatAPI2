using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    public class Measurement
    {
        [Key]
        public Int32 Id { get; set; }
        [NotMapped]
        public String Name { get; set; }
        [Column("datetime")]
        public DateTime Datetime { get; set; }
        public decimal Value { get; set; }
        [NotMapped]
        public string Unit { get; set; }
        [NotMapped]
        public Boolean Controllable { get; set; }
        [NotMapped]
        public int modBusSlaveidAddress { get; set; }
        [NotMapped]
        public int modBusAddress { get; set; }
        [NotMapped]
        public int modBusCount { get; set; }
        [NotMapped]
        public int modBusSize { get; set; }
        [NotMapped]
        public String modBusEndpoint { get; set; }
    }
}

