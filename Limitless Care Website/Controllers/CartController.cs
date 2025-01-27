﻿using Limitless.Services.Services.CartServices;
using Limitless_Care_Website.Data;
using Limitless_Care_Website.Logic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
        public ResultViewModel GetSectionsName(int Id)
        {
            return CartServices.GetSectionsName(Id);
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
        [HttpGet]
        public ResultViewModel GetSectionsName_Ar(int Id)
        {
            return CartServices.GetSectionsName_Ar(Id);
        }

        //Request 
        [HttpPost]
        public ResultViewModel InsertRequest(RequestViewModel model)
        {
          return  CartServices.AddRequest(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ResultViewModel GetRequests()
        {
            return CartServices.GetRequests();
        }
        //Admin Tool
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ResultViewModel AddCart(CartViewModel model)
        {
            return CartServices.AddCart(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut]
        public ResultViewModel EditMainCart(CartViewModel model)
        {
            return CartServices.EditMain(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public ResultViewModel DeleteCart(int id)
        {
            return CartServices.DeleteCart(id);
        }



    }
}
