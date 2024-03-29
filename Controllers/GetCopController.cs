﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeatAPI.DataContext;
using HeatAPI.Models;
using HeatAPI2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeatAPI2.Controllers
{
    [ApiController]
    [Route("api/Get/")]
    [Produces("application/json")]
    public class GetCopController : Controller
    {
        public GetCopController(VarmedataContext context)
        {
            _context = context;

        }
        private readonly VarmedataContext _context;

        [HttpGet("cop")]
        public ActionResult<List<Cop>> COP()
        {

            Cop _cop = new Cop(_context);
            _cop.Calculate();

            MeasurementApi cop = new MeasurementApi
            {
                Name = "Cop Value",
                Value = _cop.Value.ToString().Substring(0, 4)
            };

            JsonResult Measurementsresult = new JsonResult(cop);

            return Measurementsresult;

        }
    }
}