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
    [Route("api/Get/24h/")]
    [Produces("application/json")]
    public class Get24hstatsController : Controller
    {
        public Get24hstatsController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;

        // post: /tude
        [HttpPost]
        public ActionResult<IEnumerable> All([FromBody] Get24h model)
        {
            {
                using (_context)
                {
                  string measurementType = model.MeasurementType.ToString();
                  var sql = "SELECT [datetime], [value] from ( Select top 1440 * FROM {0} order by datetime desc) as total order by datetime asc";
                  string computedsql = string.Format(sql, measurementType);
                  var Item = _context.H24.FromSqlRaw(computedsql).ToList();
                  return Item;
                }
            }

        }
    }
    public class Get24h
    {
        public String MeasurementType { set; get; }
    }

}