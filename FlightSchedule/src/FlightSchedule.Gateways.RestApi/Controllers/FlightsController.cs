﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using FlightSchedule.Application.Contracts;

namespace FlightSchedule.Gateways.RestApi.Controllers
{
    public class FlightsController : ApiController
    {
        private IFlightGenerationService _service;
        public FlightsController(IFlightGenerationService service)
        {
            _service = service;
        }

        public void Post(FlightCalculationRequestDto dto)
        {
            Thread.Sleep(3000); //just for loading test
            _service.Generate(dto);
        }

        public List<FlightDto> Get(string flightNo)
        {
            return _service.Get(flightNo);
        }
    }
}