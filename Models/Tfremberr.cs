using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tfremberr : Measurement
    {
        public Tfremberr()
        {
            Name = "Tfremberr";
            Unit = "°C";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 43009;
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
