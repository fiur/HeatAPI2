using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HeatAPI.Models
{
    public class Measurement
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public DateTime Datetime { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }
        public Boolean Controllable { get; set; }
        public int modBusSlaveidAddress { get; set; }
        public int modBusAddress { get; set; }
        public int modBusCount { get; set; }
        public int modBusSize { get; set; }
        public String modBusEndpoint { get; set; }
    }
}

