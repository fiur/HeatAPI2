using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Pprodvv : Measurement
    {
        public Pprodvv()
        {
            Name = "Pprodvv";
            Unit = "kwh";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class PprodvvMeasurement : MeasurementRequest
    {

        public PprodvvMeasurement()
        {
            // Dette er en test for github upload
            modBusAddress = 1;
            modBusSlaveidAddress = 44306;
            modBusCount = 1;
            modBusSize = 32;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/uint32/";
        }
    }
}
