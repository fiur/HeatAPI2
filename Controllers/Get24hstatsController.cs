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
    [Route("api/Get/24h/")]
    [Produces("application/json")]
    public class Get24hstatsController : Controller
    {
        public Get24hstatsController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;

        // GET: lowest/tude
        [HttpGet("lowest/{m}")]
        public ActionResult<List<Dummy>> Lowest(string m)
        {
            using (_context)
            {
                var Item = _context.Dummy.FromSqlRaw("Select top 1 * FROM " + m + " where (datetime >= DATEADD(day, -1, GETDATE()) order by value asc").ToList<Dummy>();
                return Item;
            }
        }

        // GET: highest/tude
        [HttpGet("highest/{m}")]
        public ActionResult<List<Dummy>> Highest(string m)
        {
            using (_context)
            {
                var Item = _context.Dummy.FromSqlRaw("Select top 1 * FROM " + m + " where (datetime >= DATEADD(day, -1, GETDATE()) order by value desc").ToList<Dummy>();
                return Item;
            }
        }


        // GET: /tude
        [HttpGet("{m}")]
        public ActionResult<List<Dummy>> All(string m)
        {
            {
                using (_context)
                {
                  //  var Item = _context.Dummy.FromSqlRaw("SELECT q.* FROM (Select top 10 * FROM " + m + " order by datetime desc) q ORDER BY q.datetime ASC").ToList<Dummy>();
                    var Item = _context.Dummy.FromSqlRaw("Select top 20 * FROM " + m + " order by datetime desc").ToList<Dummy>();
                    return Item;
                }
            }

        }
    }
}