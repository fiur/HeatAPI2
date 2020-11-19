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
using React.Sample.Webpack.CoreMvc;

namespace HeatAPI.Controllers
{
    [Route("api/Get/ts")]
    [Produces("application/json")]
    public class GetTimeseriesController : Controller
    {
        
        public GetTimeseriesController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;


       
        [HttpPost]
        public async Task<ActionResult<IEnumerable>> GetTimeseries([FromBody] GetTimeseries model)
        {
            using (_context)
            {
                string measurementType = model.measurementType.ToString();
                string groupsize = model.groupsize.ToString();
                string startdate = model.starttime.Date.ToString("yyyy-MM-dd");
                string enddate = model.endtime.Date.ToString("yyyy-MM-dd");
                string minsql = ", MIN(aa.[value]) AS [min]";
                string maxsql = ", MAX(aa.[value]) AS [max]";
                string avgsql = ", AVG(aa.[value]) AS [avg]";

                string sql = "SELECT DATEADD(MINUTE, DATEDIFF(MINUTE, '2000', aa.[datetime]) / {0} * {0}, '2000') AS [date], COUNT(*) AS[rii] {3} {4} {5} FROM [heatmonitor].[dbo].[{6}] AS aa WHERE aa.datetime > CONVERT(datetime, '{1}') AND aa.datetime < CONVERT(datetime, '{2}') GROUP BY DATEADD(MINUTE, DATEDIFF(MINUTE, '2000', aa.[datetime]) / {0} * {0}, '2000') ORDER BY [date]";

                string computedsql = string.Format(sql, groupsize, startdate, enddate, minsql, maxsql, avgsql, measurementType);

                var Item = _context.TS.FromSqlRaw(computedsql).ToList();

                return Item;
            }
        }
    }

    public class GetTimeseries
    {
        public String measurementType { set; get; }
        public DateTime starttime { set; get; } 
        public DateTime endtime { set; get; } 
        public int groupsize { set; get; } 
        public Boolean min { set; get; }
        public Boolean max { set; get; }
        public Boolean avg { set; get; }
    }
}