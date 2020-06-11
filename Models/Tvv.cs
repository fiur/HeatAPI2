using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tvv : Measurement
    {
        public Tvv()
        {
            Name = "Tvv";
            Unit = "°C";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TvvMeasurement : MeasurementRequest
    {

        public TvvMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 40013;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}

