﻿using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tvv : Measurement
    {
        public Tvv()
        {
            Name = "Tvv";
            Unit = "°C";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 40013;
            modBusCount = 1;
            modBusSize = 16;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            multiplier = 10;
        }
        public void convert()
        {
            Value = Value / multiplier;
        }
    }

}

