using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tfremberr : Measurement
    {
        public Tfremberr()
        {
            Name = "Tfremberr";
            Unit = "°C";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TfremberrMeasurement : MeasurementRequest
    {

        public TfremberrMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 43009;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
