using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeatAPI.Models;
using HeatAPI.DataContext;
using System.Dynamic;
using System.Collections;
using System.Text.Json;

namespace HeatAPI.Controllers
{
    [ApiController]
    [Route("api/Get/Multiplier")]
    [Produces("application/json")]
    public class GetMultiplierController : Controller
    {
        //Localhost:5555/api/Get/tude/5
        public GetMultiplierController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;


        // GET: api/get/Multiplier/n
        [HttpGet("{m}/{n}")]
        public ActionResult<List<Measurement>> GetN(long n, string m)
        {
            using (_context)
            {

                var Item = _context.Measurement.FromSqlRaw("Select top " + n + " * FROM " + m + " order by datetime desc").ToList<Measurement>();

                return Item;
            }
        }
    }

}