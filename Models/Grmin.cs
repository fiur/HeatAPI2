using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Grmin : Measurement
    {
        public Grmin()
        {
            Name = "Grmin";
            Unit = "";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 43005;
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
