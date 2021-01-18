using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    public interface IMinterface
    {
        Int32 Id { get; set; }
        DateTime Datetime { get; set; }
        decimal Value { get; set; }
        String Name { get; set; }
        string Unit { get; set; }
        Int32 Multiplier { get; set; }
        Boolean Controllable { get; set; }
        int ModBusSlaveidAddress { get; set; }
        int ModBusAddress { get; set; }
        int ModBusCount { get; set; }
        int ModBusSize { get; set; }
        String ModBusEndpoint { get; set; }
    }
}

