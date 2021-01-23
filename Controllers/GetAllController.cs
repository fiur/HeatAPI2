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
    [Route("api/Get/all")]
    [Produces("application/json")]
    public class GetAllController : Controller
    {
        //Localhost:5555/api/Get/tude/5222
        public GetAllController(VarmedataContext context)
        {
            _context = context;
        }

        private readonly VarmedataContext _context;

        public JsonResult GetAll()
        {
            using (_context)
            {
                // Create a List
                List<IMinterface> Mlist = new List<IMinterface>();

                Tinde _tinde = _context.Tinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add((IMinterface)_tinde);

                Tude _tude = _context.Tude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add((IMinterface)_tude);

                //Treturr _treturr = _context.Treturr.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_treturr);

                //Tvv _tvv = _context.Tvv.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_tvv);

                //Tzinde _tzinde = _context.Tzinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_tzinde);

                //Tfremr _tfremr = _context.Tfremr.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_tfremr);

                //Tfremberr _tfremberr = _context.Tfremberr.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_tfremberr);

                //Tfrainde _tfrainde = _context.Tfrainde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_tfrainde);

                //Vkurve _vkurve = _context.Vkurve.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_vkurve);

                //Qcirc _qcirc = _context.Qcirc.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_qcirc);

                //Ptotude _ptotude = _context.Ptotude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_ptotude);

                //Pude _pude = _context.Pude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_pude);

                //Pprodvv _pprodvv = _context.Pprodvv.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_pprodvv);

                //Pprodvarme _pprodvarme = _context.Pprodvarme.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_pprodvarme);

                //Grmin _grmin = _context.Grmin.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_grmin);

                //Componoff _componoff = _context.Componoff.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_componoff);

                //Alarmer _alarmer = _context.Alarmer.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_alarmer);

                //Ttilinde _ttilinde = _context.Ttilinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_ttilinde);

                //Tstopude _tstopude = _context.Tstopude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                //Mlist.Add(_tstopude);

                JsonResult Measurementsresult = new JsonResult(Mlist);

                return Measurementsresult;
            }
        }

  
    }

}