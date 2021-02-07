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

        // --- fra her 
        [HttpGet("Alarmer/{n}")]
        public ActionResult<List<Alarmer>> GetNAlarmer(int n)
        {
            using (_context)
            {
                var Item = _context.Alarmer.OrderByDescending(a => a.Datetime).Take(n).ToList<Alarmer>();
                return Item;
            }
        }

        // --- fra her Componoff
        [HttpGet("Componoff/{n}")]
        public ActionResult<List<Componoff>> GetNComponoff(int n)
        {
            using (_context)
            {
                var Item = _context.Componoff.OrderByDescending(a => a.Datetime).Take(n).ToList<Componoff>();
                return Item;
            }
        }

        // --- fra her Grmin
        [HttpGet("Grmin/{n}")]
        public ActionResult<List<Grmin>> GetNGrmin(int n)
        {
            using (_context)
            {
                var Item = _context.Grmin.OrderByDescending(a => a.Datetime).Take(n).ToList<Grmin>();
                return Item;
            }
        }

        // --- fra her Pprodvarme 
        [HttpGet("Pprodvarme/{n}")]
        public ActionResult<List<Pprodvarme>> GetNPprodvarme(int n)
        {
            using (_context)
            {
                var Item = _context.Pprodvarme.OrderByDescending(a => a.Datetime).Take(n).ToList<Pprodvarme>();
                return Item;
            }
        }

        // --- fra her Pprodvv
        [HttpGet("Pprodvv/{n}")]
        public ActionResult<List<Pprodvv>> GetNPprodvv(int n)
        {
            using (_context)
            {
                var Item = _context.Pprodvv.OrderByDescending(a => a.Datetime).Take(n).ToList<Pprodvv>();
                return Item;
            }
        }

        // --- fra her Ptotude
        [HttpGet("Ptotude/{n}")]
        public ActionResult<List<Ptotude>> GetNPtotude(int n)
        {
            using (_context)
            {
                var Item = _context.Ptotude.OrderByDescending(a => a.Datetime).Take(n).ToList<Ptotude>();
                return Item;
            }
        }

        // --- fra her Pude
        [HttpGet("Pude/{n}")]
        public ActionResult<List<Pude>> GetNPude(int n)
        {
            using (_context)
            {
                var Item = _context.Pude.OrderByDescending(a => a.Datetime).Take(n).ToList<Pude>();
                return Item;
            }
        }

        // --- fra her Qcirc
        [HttpGet("Qcirc/{n}")]
        public ActionResult<List<Qcirc>> GetNQcirc(int n)
        {
            using (_context)
            {
                var Item = _context.Qcirc.OrderByDescending(a => a.Datetime).Take(n).ToList<Qcirc>();
                return Item;
            }
        }

        // --- fra her Tfrainde
        [HttpGet("Tfrainde/{n}")]
        public ActionResult<List<Tfrainde>> GetNTfrainde(int n)
        {
            using (_context)
            {
                var Item = _context.Tfrainde.OrderByDescending(a => a.Datetime).Take(n).ToList<Tfrainde>();
                return Item;
            }
        }

        // --- fra her Tfremberr
        [HttpGet("Tfremberr/{n}")]
        public ActionResult<List<Tfremberr>> GetNTfremberr(int n)
        {
            using (_context)
            {
                var Item = _context.Tfremberr.OrderByDescending(a => a.Datetime).Take(n).ToList<Tfremberr>();
                return Item;
            }
        }

        // --- fra her Tfremr
        [HttpGet("Tfremr/{n}")]
        public ActionResult<List<Tfremr>> GetNTfremr(int n)
        {
            using (_context)
            {
                var Item = _context.Tfremr.OrderByDescending(a => a.Datetime).Take(n).ToList<Tfremr>();
                return Item;
            }
        }

        // --- fra her Tinde
        [HttpGet("Tinde/{n}")]
        public ActionResult<List<Tinde>> GetNTinde(int n)
        {
            using (_context)
            {
                var Item = _context.Tinde.OrderByDescending(a => a.Datetime).Take(n).ToList<Tinde>();
                return Item;
            }
        }

        // --- fra her Treturr
        [HttpGet("Treturr/{n}")]
        public ActionResult<List<Treturr>> GetNTreturr(int n)
        {
            using (_context)
            {
                var Item = _context.Treturr.OrderByDescending(a => a.Datetime).Take(n).ToList<Treturr>();
                return Item;
            }
        }

        // --- fra her Tstopude 
        [HttpGet("Tstopude/{n}")]
        public ActionResult<List<Tstopude>> GetNTstopude(int n)
        {
            using (_context)
            {
                var Item = _context.Tstopude.OrderByDescending(a => a.Datetime).Take(n).ToList<Tstopude>();
                return Item;
            }
        }

        // --- fra her Ttilinde
        [HttpGet("Ttilinde/{n}")]
        public ActionResult<List<Ttilinde>> GetNTtilinde(int n)
        {
            using (_context)
            {
                var Item = _context.Ttilinde.OrderByDescending(a => a.Datetime).Take(n).ToList<Ttilinde>();
                return Item;
            }
        }

        // --- fra her Tude
        [HttpGet("Tude/{n}")]
        public ActionResult<List<Tude>> GetNTude(int n)
        {
            using (_context)
            {
                var Item = _context.Tude.OrderByDescending(a => a.Datetime).Take(n).ToList<Tude>();
                return Item;
            }
        }

        // --- fra her Tvv
        [HttpGet("Tvv/{n}")]
        public ActionResult<List<Tvv>> GetNTvv(int n)
        {
            using (_context)
            {
                var Item = _context.Tvv.OrderByDescending(a => a.Datetime).Take(n).ToList<Tvv>();
                return Item;
            }
        }

        // --- fra her Tzinde
        [HttpGet("Tzinde/{n}")]
        public ActionResult<List<Tzinde>> GetNTzinde(int n)
        {
            using (_context)
            {
                var Item = _context.Tzinde.OrderByDescending(a => a.Datetime).Take(n).ToList<Tzinde>();
                return Item;
            }
        }

        // --- fra her Vkurve
        [HttpGet("Vkurve/{n}")]
        public ActionResult<List<Vkurve>> GetNVkurve(int n)
        {
            using (_context)
            {
                var Item = _context.Vkurve.OrderByDescending(a => a.Datetime).Take(n).ToList<Vkurve>();
                return Item;
            }
        }

    }

}