using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tinde : Measurement
    {
        public Tinde()
        {
            Name = "Tinde";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TindeMeasurement : MeasurementRequest
    { 
    
        public TindeMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 40033;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}

