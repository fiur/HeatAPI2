using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Ttilinde : Measurement
    {
        public Ttilinde()
        {
            Name = "Tilinde";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TtilindeMeasurement : MeasurementRequest
    {

        public TtilindeMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 44058;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
