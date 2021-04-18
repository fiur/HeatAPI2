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
    [ApiController]
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
        public ActionResult<IEnumerable> GetTimeseries([FromBody] GetTimeseries model)
        {
            using (_context)
            {
                string measurementType = model.MeasurementType.ToString();
                string groupSize = model.GroupSize.ToString();
                string startDate = model.StartTime.Date.ToString("yyyy-MM-dd");
                string endDate = model.EndTime.Date.ToString("yyyy-MM-dd");
                string reqFunction = model.ReqFunction.ToString();
                string sqlFunc = "";

                switch (reqFunction)
                {
                    case "min":
                        sqlFunc = ", MIN(aa.[value]) AS [func]";
                        break;
                    case "max":
                        sqlFunc = ", MAX(aa.[value]) AS [func]";
                        break;
                    case "avg":
                        sqlFunc = ", AVG(aa.[value]) AS [func]";
                        break;
                }

                string sql = "SELECT DATEADD(MINUTE, DATEDIFF(MINUTE, '2000', aa.[datetime]) / {0} * {0}, '2000') AS [date], COUNT(*) AS[rii] {3} FROM [heatmonitor].[dbo].[{4}] AS aa WHERE aa.datetime > CONVERT(datetime, '{1}') AND aa.datetime < CONVERT(datetime, '{2}') GROUP BY DATEADD(MINUTE, DATEDIFF(MINUTE, '2000', aa.[datetime]) / {0} * {0}, '2000') ORDER BY [date]";

                string computedsql = string.Format(sql, groupSize, startDate, endDate, sqlFunc, measurementType);

                var Item = _context.TS.FromSqlRaw(computedsql).ToList();

                return Item;
            }
        }
    }

    public class GetTimeseries
    {
        public String MeasurementType { set; get; }
        public DateTime StartTime { set; get; } 
        public DateTime EndTime { set; get; } 
        public String GroupSize { set; get; } 
        public String ReqFunction { set; get; }
    }
}