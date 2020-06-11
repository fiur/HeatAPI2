using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Pude : Measurement
    {
        public Pude()
        {
            Name = "Pude";
            Unit = "watt";
            Controllable = false;
        }

        public void convert() {
            Value =  Value / 10;
        }
    }

    public class PudeMeasurement : MeasurementRequest
    {

        public PudeMeasurement()
        {
            modBusAddress = 2;
            modBusSlaveidAddress = 56;
            modBusCount = 1;
            modBusSize = 32;
        }
    }
}

