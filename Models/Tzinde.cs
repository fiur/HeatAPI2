using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tzinde : Measurement
    {
        public Tzinde()
        {
            Name = "Tzinde";
            Unit = "°C";
            Controllable = true;
            modBusAddress = 1;
            modBusSlaveidAddress = 47398;
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
