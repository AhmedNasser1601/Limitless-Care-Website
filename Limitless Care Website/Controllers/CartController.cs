using Limitless.Services.Services.CartServices;
using Limitless_Care_Website.Data;
using Limitless_Care_Website.Logic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unit.Data;
using Unit.Logic;
using Unit.Logic.Models;

namespace Limitless_Care_Website.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartServices CartServices;
        public CartController (ICartServices CartServices)
        {
            this.CartServices = CartServices;
        }

        [HttpGet]
        public ResultViewModel GetCartDetails(int Id) // To Get The Details Of The specific Cart 
        {
          return CartServices.GetDetailsOfCart(Id);
      
        }
    
    }
}
