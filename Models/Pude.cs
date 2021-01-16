﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Pude")]
    public class Pude : Measurement
    {
        public Pude()
        {
            Name = "Pude";
            Unit = "watt";
            Controllable = false;
            modBusAddress = 2;
            modBusSlaveidAddress = 56;
            modBusCount = 1;
            modBusSize = 32;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            multiplier = 10;
        }
        public void convert()
        {
            Value = Value / multiplier;
        }
    }
}

