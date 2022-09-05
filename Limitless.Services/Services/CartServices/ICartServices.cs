using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Logic.Models;

namespace Limitless.Services.Services.CartServices
{
    public interface ICartServices
    {
        public ResultViewModel GetMainCart();
        public ResultViewModel GetDetailsOfCartSec1(int CartId);
        public ResultViewModel GetDetailsOfCartSec2(int CartId);
        public ResultViewModel GetBenefitsOfCart(int CartId);
        public ResultViewModel AddRequest(RequestViewModel model);

        public ResultViewModel GetMainCart_Ar();
        public ResultViewModel GetDetailsOfCartSec1_Ar(int CartId);
        public ResultViewModel GetDetailsOfCartSec2_Ar(int CartId);
        public ResultViewModel GetBenefitsOfCart_Ar(int CartId);

    }
}
