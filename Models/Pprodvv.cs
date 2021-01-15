using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Pprodvv : Measurement
    {
        public Pprodvv()
        {
            Name = "Pprodvv";
            Unit = "kwh";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 44306;
            modBusCount = 1;
            modBusSize = 32;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/uint32/";
            multiplier = 10;
        }
        public void convert()
        {
            Value = Value / multiplier;
        }
    }
}
