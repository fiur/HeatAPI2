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
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class GrminMeasurement : MeasurementRequest
    {

        public GrminMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 43005;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
