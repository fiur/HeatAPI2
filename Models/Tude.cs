using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Tude")]
    public class Tude : IMinterface
    {
        [Key]
        public Int32 Id { get; set; }
        [Column("datetime")]
        public DateTime Datetime { get; set; }
        [Column("value")]
        public decimal Value { get; set; }
        [NotMapped]
        public String Name { get; set; }
        [NotMapped]
        public string Unit { get; set; }
        [NotMapped]
        public Int32 Multiplier { get; set; }
        [NotMapped]
        public Boolean Controllable { get; set; }
        [NotMapped]
        public int ModBusSlaveidAddress { get; set; }
        [NotMapped]
        public int ModBusAddress { get; set; }
        [NotMapped]
        public int ModBusCount { get; set; }
        [NotMapped]
        public int ModBusSize { get; set; }
        [NotMapped]
        public String ModBusEndpoint { get; set; }

        public Tude()
        {
            Name = "Tude";
            Unit = "°C";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 40004;
            ModBusCount = 1;
            ModBusSize = 16;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 10;
        }
        public void Convert()
        {
            Value /= Multiplier;
        }
    }
}

