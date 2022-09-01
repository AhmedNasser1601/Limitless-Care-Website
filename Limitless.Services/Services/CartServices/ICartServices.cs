using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Logic.Models;

namespace Limitless.Services.Services.CartServices
{
    public interface ICartServices
    {
        public ResultViewModel GetMainCart(int CartId);
        public ResultViewModel GetDetailsOfCart(int CartId); 
        public ResultViewModel GetBenefitsOfCart(int CartId);

    }
}
