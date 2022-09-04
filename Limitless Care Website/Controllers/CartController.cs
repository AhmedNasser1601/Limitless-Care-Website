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

        #region GetEnglishData
        [HttpGet]
        public ResultViewModel GetMainCart()
        {
            return CartServices.GetMainCart();

        }
        [HttpGet]
        public ResultViewModel GetCartDetails(int Id)
        {
            return CartServices.GetDetailsOfCart(Id);

        }
        [HttpGet]
        public ResultViewModel GetCartBenefits(int Id)
        {
            return CartServices.GetBenefitsOfCart(Id);

        }
        #endregion

        #region GetArabicData
        [HttpGet]
        public ResultViewModel GetMainCart_Ar()
        {
            return CartServices.GetMainCart_Ar();

        }
        [HttpGet]
        public ResultViewModel GetCartDetails_Ar(int Id)
        {
            return CartServices.GetDetailsOfCart_Ar(Id);

        }
        public ResultViewModel GetCartBenefits_Ar(int Id)
        {
            return CartServices.GetBenefitsOfCart_Ar(Id);

        }
        #endregion
        [HttpPost]
        public void InsertRequest(RequestViewModel model)
        {
            CartServices.AddRequest(model);
        }

    }
}
