using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Alarmer : Measurement
    {
        public Alarmer()
        {
            Name = "Alarmer";
            Unit = "stk";
            Controllable = false;
        }
    }

    public class AlarmerMeasurement : MeasurementRequest
    {

        public AlarmerMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 41000;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
