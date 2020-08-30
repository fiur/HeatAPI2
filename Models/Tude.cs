using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tude : Measurement
    {
        public Tude()
        {
            Name = "Tude";
            Unit = "°C";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 40004;
            modBusCount = 1;
            modBusSize = 16;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }
}

