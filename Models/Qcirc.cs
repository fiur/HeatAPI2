using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Qcirc : Measurement
    {
        public Qcirc()
        {
            Name = "Qcirc";
            Unit = "l/min";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class QcircMeasurement : MeasurementRequest
    {

        public QcircMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 40072;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}

