using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Pprodvarme : Measurement
    {
        public Pprodvarme()
        {
            Name = "Pprodvarme";
            Unit = "kwh";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 44308;
            modBusCount = 1;
            modBusSize = 32;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/uint32/";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }
}
