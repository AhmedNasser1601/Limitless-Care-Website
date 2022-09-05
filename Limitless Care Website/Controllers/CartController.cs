using Limitless.Services.Services.CartServices;
using Limitless_Care_Website.Data;
using Limitless_Care_Website.Logic.Models;
using Microsoft.AspNetCore.Cors;
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

        // Get Data In English
        [HttpGet]
        public ResultViewModel GetMainCart()
        {
            return CartServices.GetMainCart();

        }
        [HttpGet]
        public ResultViewModel GetCartDetailsSection1(int Id)
        {
            return CartServices.GetDetailsOfCartSec1(Id);

        }
        [HttpGet]
        public ResultViewModel GetCartDetailsSection2(int Id)
        {
            return CartServices.GetDetailsOfCartSec2(Id);

        }
        [HttpGet]
        public ResultViewModel GetCartBenefits(int Id)
        {
            return CartServices.GetBenefitsOfCart(Id);

        }
        // Get Data In Arabic
        [HttpGet]
        public ResultViewModel GetMainCart_Ar()
        {
            return CartServices.GetMainCart_Ar();

        }
        [HttpGet]
        public ResultViewModel GetCartDetailsSection1_Ar(int Id)
        {
            return CartServices.GetDetailsOfCartSec1_Ar(Id);

        }
        [HttpGet]
        public ResultViewModel GetCartDetailsSection2_Ar(int Id)
        {
            return CartServices.GetDetailsOfCartSec2_Ar(Id);

        }
        public ResultViewModel GetCartBenefits_Ar(int Id)
        {
            return CartServices.GetBenefitsOfCart_Ar(Id);

        }

        //Request 
        [HttpPost]
        public ResultViewModel InsertRequest(RequestViewModel model)
        {
          return  CartServices.AddRequest(model);
        }

    }
}
