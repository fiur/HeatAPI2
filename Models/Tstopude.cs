using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tstopude : Measurement
    {
        public Tstopude()
        {
            Name = "Tstopude";
            Unit = "°C";
            Controllable = true;
            modBusAddress = 1;
            modBusSlaveidAddress = 47375;
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
