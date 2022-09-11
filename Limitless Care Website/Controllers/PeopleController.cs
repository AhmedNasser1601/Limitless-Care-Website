using Limitless.Services.Services.PeopleServices;
using Limitless_Care_Website.Logic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ResultViewModel GetPerson(int id)
        {
            return PeopleServices.GetPerson(id);
        }
        // Get People In Aeabic
        [HttpGet]
        public ResultViewModel GetPeoples_Ar()
        {
            return PeopleServices.GetPeoples_Ar();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ResultViewModel AddPerson(PeopleViewModel model)
        {
            return PeopleServices.AddPerson(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut]
        public ResultViewModel EditPerson(PeopleViewModel model)
        {
            return PeopleServices.EditPerson(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public ResultViewModel DeletePerson(int id)
        {
            return PeopleServices.DeletePerson(id);
        }

    }
}
