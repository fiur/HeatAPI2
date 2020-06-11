using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tfremr : Measurement
    {
        public Tfremr()
        {
            Name = "Tfremr";
            Unit = "°C";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TfremrMeasurement : MeasurementRequest
    {

        public TfremrMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 40008;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}

