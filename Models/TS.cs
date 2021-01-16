using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [NotMapped]
    public class TS
    {
        public DateTime date { set; get; }
        public int rii { set; get; }
        public Decimal func { set; get; }
    }

}

