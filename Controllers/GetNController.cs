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
    [Route("api/Get/")]
    [Produces("application/json")]
    public class GetNController : Controller
    {
        //Localhost:5555/api/Get/tude/5
        public GetNController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;


        // GET: api/alarmer/n
        [HttpGet("{m}/{n}")]
        public async Task<ActionResult<List<Dummy>>> GetN(long n, string m)
        {
            using (_context)
            {
                var Item = _context.Dummy.FromSqlRaw("Select top " + n + " * FROM " + m + " order by datetime desc").ToList<Dummy>();
                return Item;
            }
        }
    }

}