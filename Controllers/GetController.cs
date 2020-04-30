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
    public class GetController : Controller
    {
        //Localhost:5555/api/Get/tude/5
        public GetController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;


        [HttpGet("all")]
        [Produces("application/json")]
        public JsonResult GetAll()
        {
            using (_context)
            {
                // Create a List
                List<Measurement> Measurements = new List<Measurement>();

                Tinde _tinde = _context.Tinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tinde);

                Tude _tude = _context.Tude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tude);

                Treturr _treturr = _context.Treturr.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_treturr);

                Tvv _tvv = _context.Tvv.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tvv);

                Tzinde _tzinde = _context.Tzinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tzinde);

                Tfremr _tfremr = _context.Tfremr.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tfremr);

                Tfremberr _tfremberr = _context.Tfremberr.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tfremberr);

                Tfrainde _tfrainde = _context.Tfrainde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tfrainde);

                Vkurve _vkurve = _context.Vkurve.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_vkurve);

                Qcirc _qcirc = _context.Qcirc.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_qcirc);

                Ptotude _ptotude = _context.Ptotude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_ptotude);

                Pude _pude = _context.Pude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_pude);

                Pprodvv _pprodvv = _context.Pprodvv.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_pprodvv);

                Pprodvarme _pprodvarme = _context.Pprodvarme.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_pprodvarme);

                Grmin _grmin = _context.Grmin.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_grmin);

                Componoff _componoff = _context.Componoff.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_componoff);

                Alarmer _alarmer = _context.Alarmer.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_alarmer);

                Ttilinde _ttilinde = _context.Ttilinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_ttilinde);

                Tstopude _tstopude = _context.Tstopude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Measurements.Add(_tstopude);

                JsonResult Measurementsresult = new JsonResult(Measurements);

                return Measurementsresult;
            }
        }

        // GET: api/alarmer/GetLatest/n
        [HttpGet("alarmer/{n}")]
        public async Task<ActionResult<List<Alarmer>>> GetAlarmer(long n)
        {
            using (_context)
            {
                var Item = _context.Alarmer.FromSqlRaw("Select top " + n + " * FROM alarmer order by datetime desc").ToList<Alarmer>();
                return Item;
            }
        }
        [Produces("application/json")]
        [HttpGet("Tude/{n}")]
        public async Task<ActionResult<List<Tude>>> GetTude(long n)
        {
            using (_context)
            {
                var Item = _context.Tude.FromSqlRaw("Select top " + n + " * FROM tude order by datetime desc").ToList<Tude>();
                return Item;
            }
        }
        [HttpGet("Componoff/{n}")]
        public async Task<ActionResult<List<Componoff>>> GetComponoff(long n)
        {
            using (_context)
            {
                var Item = _context.Componoff.FromSqlRaw("Select top " + n + " * FROM Componoff order by datetime desc").ToList<Componoff>();
                return Item;
            }
        }
        [HttpGet("Grmin/{n}")]
        public async Task<ActionResult<List<Grmin>>> GetGrmin(long n)
        {
            using (_context)
            {
                var Item = _context.Grmin.FromSqlRaw("Select top " + n + " * FROM Grmin order by datetime desc").ToList<Grmin>();
                return Item;
            }
        }
    
        [HttpGet("Pprodvarme/{n}")]
        public async Task<ActionResult<List<Pprodvarme>>> GetPprodvarme(long n)
        {
            using (_context)
            {
                var Item = _context.Pprodvarme.FromSqlRaw("Select top " + n + " * FROM Pprodvarme order by datetime desc").ToList<Pprodvarme>();
                return Item;
            }
        }

        [HttpGet("Pprodvv/{n}")]
        public async Task<ActionResult<List<Pprodvv>>> GetPprodvv(long n)
        {
            using (_context)
            {
                var Item = _context.Pprodvv.FromSqlRaw("Select top " + n + " * FROM Pprodvv order by datetime desc").ToList<Pprodvv>();
                return Item;
            }
        }
        [HttpGet("Ptotude/{n}")]
        public async Task<ActionResult<List<Ptotude>>> GetPtotude(long n)
        {
            using (_context)
            {
                var Item = _context.Ptotude.FromSqlRaw("Select top " + n + " * FROM Ptotude order by datetime desc").ToList<Ptotude>();
                return Item;
            }
        }
    
        [HttpGet("Pude/{n}")]
        public async Task<ActionResult<List<Pude>>> GetPude(long n)
        {
            using (_context)
            {
                var Item = _context.Pude.FromSqlRaw("Select top " + n + " * FROM Pude order by datetime desc").ToList<Pude>();
                return Item;
            }
        }
        [HttpGet("Qcirc/{n}")]
        public async Task<ActionResult<List<Qcirc>>> GetQcirc(long n)
        {
            using (_context)
            {
                var Item = _context.Qcirc.FromSqlRaw("Select top " + n + " * FROM Qcirc order by datetime desc").ToList<Qcirc>();
                return Item;
            }
        }
        [HttpGet("Tfrainde/{n}")]
        public async Task<ActionResult<List<Tfrainde>>> GetTfrainde(long n)
        {
            using (_context)
            {
                var Item = _context.Tfrainde.FromSqlRaw("Select top " + n + " * FROM Tfrainde order by datetime desc").ToList<Tfrainde>();
                return Item;
            }
        }
        [HttpGet("Tfremberr/{n}")]
        public async Task<ActionResult<List<Tfremberr>>> GetTfremberr(long n)
        {
            using (_context)
            {
                var Item = _context.Tfremberr.FromSqlRaw("Select top " + n + " * FROM Tfremberr order by datetime desc").ToList<Tfremberr>();
                return Item;
            }
        }
        [HttpGet("Tfremr/{n}")]
        public async Task<ActionResult<List<Tfremr>>> GetTfremr(long n)
        {
            using (_context)
            {
                var Item = _context.Tfremr.FromSqlRaw("Select top " + n + " * FROM Tfremr order by datetime desc").ToList<Tfremr>();
                return Item;
            }
        }
        [HttpGet("Tinde/{n}")]
        public async Task<ActionResult<List<Tinde>>> GetTinde(long n)
        {
            using (_context)
            {
                var Item = _context.Tinde.FromSqlRaw("Select top " + n + " * FROM Tinde order by datetime desc").ToList<Tinde>();
                return Item;
            }
        }
        [HttpGet("Treturr/{n}")]
        public async Task<ActionResult<List<Treturr>>> GetTreturr(long n)
        {
            using (_context)
            {
                var Item = _context.Treturr.FromSqlRaw("Select top " + n + " * FROM Treturr order by datetime desc").ToList<Treturr>();
                return Item;
            }
        }
        [HttpGet("Tstopude/{n}")]
        public async Task<ActionResult<List<Tstopude>>> GetTstopude(long n)
        {
            using (_context)
            {
                var Item = _context.Tstopude.FromSqlRaw("Select top " + n + " * FROM Tstopude order by datetime desc").ToList<Tstopude>();
                return Item;
            }
        }
        [HttpGet("Ttilinde/{n}")]
        public async Task<ActionResult<List<Ttilinde>>> GetTtilinde(long n)
        {
            using (_context)
            {
                var Item = _context.Ttilinde.FromSqlRaw("Select top " + n + " * FROM Ttilinde order by datetime desc").ToList<Ttilinde>();
                return Item;
            }
        }
        [HttpGet("Tvv/{n}")]
        public async Task<ActionResult<List<Tvv>>> GetTvv(long n)
        {
            using (_context)
            {
                var Item = _context.Tvv.FromSqlRaw("Select top " + n + " * FROM Tvv order by datetime desc").ToList<Tvv>();
                return Item;
            }
        }
        [HttpGet("Tzinde/{n}")]
        public async Task<ActionResult<List<Tzinde>>> GetTzinde(long n)
        {
            using (_context)
            {
                var Item = _context.Tzinde.FromSqlRaw("Select top " + n + " * FROM Tzinde order by datetime desc").ToList<Tzinde>();
                return Item;
            }
        }
        [HttpGet("Vkurve/{n}")]
        public async Task<ActionResult<List<Vkurve>>> GetVkurve(long n)
        {
            using (_context)
            {
                var Item = _context.Vkurve.FromSqlRaw("Select top " + n + " * FROM Vkurve order by datetime desc").ToList<Vkurve>();
                return Item;
            }
        }
    }

}