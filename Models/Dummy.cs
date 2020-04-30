using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Dummy : Measurement
    {
        public Dummy()
        {
            Name = "Dummy";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class DummyMeasurement : MeasurementRequest
    { 
    
        public DummyMeasurement()
        {
            modBusAddress = 0;
            modBusSlaveidAddress = 0;
            modBusCount = 0;
            modBusSize = 0;
        }
    }
}

