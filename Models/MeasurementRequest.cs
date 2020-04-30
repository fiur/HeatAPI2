using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class MeasurementRequest
    {
        public int modBusAddress = 1;
        public int modBusSlaveidAddress = 10000;
        public int modBusCount = 1;
        public int modBusSize = 1;
        public String modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
        public int SlaveId
        {
            get
            {
                return modBusAddress;
            }
            set
            {
                modBusAddress = value;
            }
        }
        public int Address
        {
            get
            {
                return modBusSlaveidAddress;
            }
            set
            {
                modBusSlaveidAddress = value;
            }
        }
        public int Count
        {
            get
            {
                return modBusCount;
            }
            set
            {
                modBusCount = value;
            }
        }
        public int Size
        {
            get
            {
                return modBusSize;
            }
            set
            {
                modBusSize = value;
            }
        }
    }
}
