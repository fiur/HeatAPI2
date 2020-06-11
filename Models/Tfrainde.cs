﻿using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Tfrainde : Measurement
    {

        public Tfrainde()
        {
            Name = "Tfrainde";
            Unit = "°C";
            Controllable = false;
        }
        public void convert()
        {
            Value = Value / 10;
        }
    }

    public class TfraindeMeasurement : MeasurementRequest
    {

        public TfraindeMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 44055;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
