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
    [Route("api/Get/modbusinfo/")]
    [Produces("application/json")]
    public class ModbusInfoController : Controller
    {
        public ModbusInfoController(VarmedataContext context)
        {
            _context = context;
        }
        private readonly VarmedataContext _context;


        //https://stackoverflow.com/questions/35937118/build-json-response-in-web-api-controller
        //https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-3.1

        [HttpGet("MA/tinde")]
        public IEnumerable<MeasurementApiCollection> MA()
        {

            var apiResult = new MeasurementApiCollection();

            TindeMeasurement _tindem = new TindeMeasurement();

            MeasurementApi mbAddress = new MeasurementApi();
            MeasurementApi mbCount = new MeasurementApi();
            MeasurementApi mbEndpoint = new MeasurementApi();
            MeasurementApi mbSize = new MeasurementApi();
            MeasurementApi mbSlaveidAddress = new MeasurementApi();


            mbAddress.Name = "modBusAddress";
            mbAddress.Value = _tindem.modBusAddress.ToString();
            mbCount.Name = "modBusCount";
            mbCount.Value = _tindem.modBusCount.ToString();
            mbEndpoint.Name = "modBusEndpoint";
            mbEndpoint.Value = _tindem.modBusEndpoint.ToString();
            mbSize.Name = "modBusSize";
            mbSize.Value = _tindem.modBusSize.ToString();
            mbSlaveidAddress.Name = "modBusSlaveidAddress";
            mbSlaveidAddress.Value = _tindem.modBusSlaveidAddress.ToString();

            apiResult.Measurement.Add(mbAddress);
            apiResult.Measurement.Add(mbCount);
            apiResult.Measurement.Add(mbEndpoint);
            apiResult.Measurement.Add(mbSize);
            apiResult.Measurement.Add(mbSlaveidAddress);

            apiResult.Status = 1;
            yield return apiResult;

        }
    }
}