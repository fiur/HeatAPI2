using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class TS
    {
        public DateTime date { set; get; }
        public int rii { set; get; }
        public Decimal func { set; get; }
    }

}

