using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Ptotude : Measurement
    {
        public Ptotude()
        {
            Name = "Ptotude";
            Unit = "kwh";
            Controllable = false;
            modBusAddress = 2;
            modBusSlaveidAddress = 52;
            modBusCount = 1;
            modBusSize = 32;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }
}
