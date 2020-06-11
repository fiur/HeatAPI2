using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Vkurve : Measurement
    {
        public Vkurve()
        {
            Name = "Vkurve";
            Unit = "";
            Controllable = true;
        }
    }

    public class VkurveMeasurement : MeasurementRequest
    {

        public VkurveMeasurement()
        {
            modBusAddress = 1;
            modBusSlaveidAddress = 47007;
            modBusCount = 1;
            modBusSize = 16;
        }
    }
}
