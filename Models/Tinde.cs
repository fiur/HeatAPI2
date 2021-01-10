using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tinde : Measurement
    {
        public Tinde()
        {
            Name = "Tinde";
            Unit = "°C";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 40033;
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

