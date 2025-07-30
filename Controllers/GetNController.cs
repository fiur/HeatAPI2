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
using System.Runtime.Intrinsics.X86;

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
        [HttpGet("Alarmnr/{n}")]
        public ActionResult<List<Alarmnr>> GetNAlarmnr(int n)
        {
            using (_context)
            {
                var Item = _context.Alarmnr.OrderByDescending(a => a.Datetime).Take(n).ToList<Alarmnr>();
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

        // --- fra her Tfrember
        [HttpGet("Tfrember/{n}")]
        public ActionResult<List<Tfrember>> GetNTfrember(int n)
        {
            using (_context)
            {
                var Item = _context.Tfrember.OrderByDescending(a => a.Datetime).Take(n).ToList<Tfrember>();
                return Item;
            }
        }

        // --- fra her Tfrem
        [HttpGet("Tfrem/{n}")]
        public ActionResult<List<Tfrem>> GetNTfrem(int n)
        {
            using (_context)
            {
                var Item = _context.Tfrem.OrderByDescending(a => a.Datetime).Take(n).ToList<Tfrem>();
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

        // --- fra her Tretur
        [HttpGet("Tretur/{n}")]
        public ActionResult<List<Tretur>> GetNTretur(int n)
        {
            using (_context)
            {
                var Item = _context.Tretur.OrderByDescending(a => a.Datetime).Take(n).ToList<Tretur>();
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

  // --- fra her Treturfordeler
        [HttpGet("Treturfordeler/{n}")]
        public ActionResult<List<Treturfordeler>> GetNTreturfordeler(int n)
        {
             using (_context)
             {
                    var Item = _context.Treturfordeler.OrderByDescending(a => a.Datetime).Take(n).ToList<Treturfordeler>();
                    return Item;
             }
        }

        // --- fra her Tfremfordeler
        [HttpGet("Tfremfordeler/{n}")]
        public ActionResult<List<Tfremfordeler>> GetNTfremfordeler(int n)
        {
            using (_context)
            {
                var Item = _context.Tfremfordeler.OrderByDescending(a => a.Datetime).Take(n).ToList<Tfremfordeler>();
                return Item;
            }
        }

        // --- fra her Treturradiator
        [HttpGet("Treturradiator/{n}")]
        public ActionResult<List<Treturradiator>> GetNTreturradiator(int n)
        {
            using (_context)
            {
                var Item = _context.Treturradiator.OrderByDescending(a => a.Datetime).Take(n).ToList<Treturradiator>();
                return Item;
            }
        }

        // --- fra her Trumfordeler
        [HttpGet("Trumfordeler/{n}")]
        public ActionResult<List<Trumfordeler>> GetNTrumfordeler(int n)
        {
            using (_context)
            {
                var Item = _context.Trumfordeler.OrderByDescending(a => a.Datetime).Take(n).ToList<Trumfordeler>();
                return Item;
            }
        }

        // --- fra her Qcircradiator
        [HttpGet("Qcircradiator/{n}")]
        public ActionResult<List<Qcircradiator>> GetNQcircradiator(int n)
        {
            using (_context)
            {
                var Item = _context.Qcircradiator.OrderByDescending(a => a.Datetime).Take(n).ToList<Qcircradiator>();
                return Item;
            }
        }



    }

}