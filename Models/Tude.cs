using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tude : Measurement
    {
        public Tude()
        {
            Name = "Tude";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TudeMeasurement : MeasurementRequest
    {

        public TudeMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 40004;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}

