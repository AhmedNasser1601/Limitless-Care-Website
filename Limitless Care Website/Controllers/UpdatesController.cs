//using Limitless.Services.Services.UpdatesServices;
using Limitless.Services.Services.UpdatesServices;
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
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ResultViewModel AddUpdate(UpdatesViewModel model)
        {
            return updatesServices.AddUpdate(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut]
        public ResultViewModel EditUpdate(UpdatesViewModel model)
        {
            return updatesServices.EditUpdate(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ResultViewModel EditView(int id)
        {
            return updatesServices.EditView(id);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public ResultViewModel DeleteUpdate(int id)
        {
            return updatesServices.DeleteUpdate(id);
        }

    }
}
