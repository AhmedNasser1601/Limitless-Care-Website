using Limitless_Care_Website.Logic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unit.Data;
using Unit.Logic;

namespace Limitless_Care_Website.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        UintOfWork uintOfWork;

        public CartController(ApplicationContext context)
        {
            this.uintOfWork = new UintOfWork(context);
        }

        public IEnumerable<CartViewModel> Get(int id) // list all
        {
            var model =   uintOfWork.Cart.Get(id);
            return model;
        }

    }
}
