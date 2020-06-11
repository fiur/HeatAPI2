using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Treturr : Measurement
    {
        public Treturr()
        {
            Name = "Treturr";
            Unit = "°C";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TreturrMeasurement : MeasurementRequest
    {

        public TreturrMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 40012;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}

