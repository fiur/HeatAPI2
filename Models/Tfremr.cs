using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tfremr : Measurement
    {
        public Tfremr()
        {
            Name = "Tfremr";
            Unit = "°C";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 40008;
            modBusCount = 1;
            modBusSize = 16;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
        }
        public void convert()
        {
            Value /= 10;
        }
    }
}

