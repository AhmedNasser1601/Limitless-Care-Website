using Limitless.Services.Services.PeopleServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unit.Logic.Models;

namespace Limitless_Care_Website.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        IPeopleServices PeopleServices;

        public PeopleController(IPeopleServices PeopleServices)
        {
            this.PeopleServices = PeopleServices;

        }
        // Get People In English
        [HttpGet]
        public ResultViewModel GetPeoples()
        {
            return PeopleServices.GetPeoples();
        }
        // Get People In Aeabic
        [HttpGet]
        public ResultViewModel GetPeoples_Ar()
        {
            return PeopleServices.GetPeoples_Ar();
        }
    }
}
