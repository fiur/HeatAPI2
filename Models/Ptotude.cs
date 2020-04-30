using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Ptotude : Measurement
    {
        public Ptotude()
        {
            Name = "Ptotude";
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class PtotudeMeasurement : MeasurementRequest
    {

        public PtotudeMeasurement()
        {
            modBusAddress = 2;
            modBusSlaveidAddress = 52;
            modBusCount = 1;
            modBusSize = 32;
        }
    }
}
