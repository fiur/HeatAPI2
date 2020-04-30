using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tstopude : Measurement
    {
        public Tstopude()
        {
            Name = "Tstopude";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TstopudeMeasurement : MeasurementRequest
    {

        public TstopudeMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 47375;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
