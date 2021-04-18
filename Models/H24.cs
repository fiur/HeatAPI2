using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{

    public class H24
    {
        public DateTime Datetime { set; get; }
        public decimal Value { get; set; }
    }

}

