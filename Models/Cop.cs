using HeatAPI.DataContext;
using HeatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatAPI2.Models
{
    public class Cop
    {
        public decimal Value { get; set; }

        public Cop(VarmedataContext context)
        {
            Value = 0.0m;
            _context = context;
        }

        private readonly VarmedataContext _context;

        public void Calculate()
        {

            Pprodvarme _pprodvarme = _context.Pprodvarme.OrderByDescending(p => p.Datetime).FirstOrDefault();
            Pprodvv _pprodvv = _context.Pprodvv.OrderByDescending(p => p.Datetime).FirstOrDefault();
            Ptotude _ptotude = _context.Ptotude.OrderByDescending(p => p.Datetime).FirstOrDefault();

            Value = (_pprodvarme.Value + _pprodvv.Value - 15897) / (_ptotude.Value - 2002);
            /* Value = (_pprodvarme.Value + _pprodvv.Value - 8385) / (_ptotude.Value - 5); */
        }

    }
}
