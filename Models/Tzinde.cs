using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tzinde : Measurement
    {
        public Tzinde()
        {
            Name = "Tzinde";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TzindeMeasurement : MeasurementRequest
    {

        public TzindeMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 47398;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
