using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeatAPI.DataContext;
using HeatAPI.Models;
using HeatAPI2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeatAPI2.Controllers
{
    [Route("api/Get/")]
    [Produces("application/json")]
    public class GetCopController : Controller
    {
        public GetCopController(VarmedataContext context)
        {
            _context = context;

        }
        private readonly VarmedataContext _context;


        //https://stackoverflow.com/questions/35937118/build-json-response-in-web-api-controller
        //https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-3.1

        [HttpGet("cop")]
        public IEnumerable<MeasurementApiCollection> COP()
        {

            var apiResult = new MeasurementApiCollection();

            Cop _cop = new Cop(_context);
            _cop.Calculate();

            MeasurementApi cop = new MeasurementApi();

            cop.Name = "Cop Value";
            cop.Value = _cop.Value.ToString().Substring(0, 4);

            apiResult.Measurement.Add(cop);

            apiResult.Status = 1;
            yield return apiResult;

        }
    }
}