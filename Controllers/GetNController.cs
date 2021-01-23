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
using Microsoft.AspNetCore.Http;
using System.Net.Mime;

namespace HeatAPI.Controllers
{
    [ApiController]
    [Route("api/Get/")]
    [Produces(MediaTypeNames.Application.Json)]
    public class GetNController : ControllerBase
    {
        //Localhost:5555/api/Get/tude/5
        public GetNController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;


        // GET: api/latest/n
        [HttpGet("latest/{m}")]
        public ActionResult<List<Tinde>> Latest(string m)
        {
            using (_context)
            {
                var Item = _context.Tinde.FromSqlRaw("Select top 1 * FROM " + m + " order by datetime desc").ToList<Tinde>();
                return Item;
            }
        }

        // GET: api/alarmer/n
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