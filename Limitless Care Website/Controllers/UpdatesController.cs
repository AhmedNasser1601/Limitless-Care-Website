//using Limitless.Services.Services.UpdatesServices;
using Limitless.Services.Services.UpdatesServices;
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
    public class UpdatesController : ControllerBase
    {
        private readonly IupdatesServices updatesServices;
        public UpdatesController(IupdatesServices updatesServices)
        {
            this.updatesServices = updatesServices;
        }
        [HttpGet]
        public ResultViewModel GetMainOfUpdates()
        {
            return updatesServices.GetMainUpdates();
        }
        [HttpGet]
        public ResultViewModel GetDetailsOfUpdates(int UpdateId)
        {
            return updatesServices.GetDetailsOfUpdates(UpdateId);
        }
        [HttpGet]
        public ResultViewModel GetMainOfUpdates_Ar()
        {
            return updatesServices.GetMainUpdates_Ar();
        }
        [HttpGet]
        public ResultViewModel GetDetailsOfUpdates_Ar(int UpdateId)
        {
            return updatesServices.GetDetailsOfUpdates_Ar(UpdateId);
        }

    }
}
