using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{

    public class TS
    {
        public DateTime Date { set; get; }
        public int Rii { set; get; }
        public Decimal Func { set; get; }
    }

}

