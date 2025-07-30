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
                List<Measurement> Mlist = new List<Measurement>();

                Tinde _tinde = _context.Tinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tinde);

                Tude _tude = _context.Tude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tude);

                Tretur _tretur = _context.Tretur.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tretur);

                Tvv _tvv = _context.Tvv.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tvv);

                Tzinde _tzinde = _context.Tzinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tzinde);

                Tfrem _tfrem = _context.Tfrem.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tfrem);

                Tfrember _tfrember = _context.Tfrember.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tfrember);

                Tfrainde _tfrainde = _context.Tfrainde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tfrainde);

                Vkurve _vkurve = _context.Vkurve.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_vkurve);

                Qcirc _qcirc = _context.Qcirc.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_qcirc);

                Ptotude _ptotude = _context.Ptotude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_ptotude);

                Pude _pude = _context.Pude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_pude);

                Pprodvv _pprodvv = _context.Pprodvv.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_pprodvv);

                Pprodvarme _pprodvarme = _context.Pprodvarme.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_pprodvarme);

                Grmin _grmin = _context.Grmin.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_grmin);

                Componoff _componoff = _context.Componoff.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_componoff);

                Alarmnr _alarmnr = _context.Alarmnr.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_alarmnr);

                Ttilinde _ttilinde = _context.Ttilinde.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_ttilinde);

                Tstopude _tstopude = _context.Tstopude.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tstopude);

                Treturfordeler _treturfordeler = _context.Treturfordeler.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_treturfordeler);

                Tfremfordeler _tfremfordeler = _context.Tfremfordeler.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_tfremfordeler);

                Treturradiator _treturradiator = _context.Treturradiator.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_treturradiator);

                Trumfordeler _trumfordeler = _context.Trumfordeler.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_trumfordeler);

                Qcircradiator _qcircradiator = _context.Qcircradiator.OrderByDescending(p => p.Datetime).FirstOrDefault();
                Mlist.Add(_qcircradiator);


                JsonResult Measurementsresult = new JsonResult(Mlist);

                return Measurementsresult;
            }
        }

  
    }

}