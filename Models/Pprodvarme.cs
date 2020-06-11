using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Pprodvarme : Measurement
    {
        public Pprodvarme()
        {
            Name = "Pprodvarme";
            Unit = "kwh";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class PprodvarmeMeasurement : MeasurementRequest
    {

        public PprodvarmeMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 44308;
            modBusCount = 1;
            modBusSize = 32;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/uint32/";

        }
    }
}
