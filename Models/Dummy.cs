using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Dummy : Measurement
    {
        public Dummy()
        {
            Name = "Dummy";
            modBusAddress = 0;
            modBusSlaveidAddress = 0;
            modBusCount = 0;
            modBusSize = 0;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            multiplier = 10;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

}

