using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;
using Unit.Logic;
using Unit.Logic.Models;

namespace Limitless.Services.Services.CartServices
{
    public class CartServices : ICartServices
    {
        private readonly UintOfWork uintOfWork;
        public CartServices(ApplicationContext context)
        {
            this.uintOfWork = new UintOfWork(context);
        }

        public ResultViewModel GetDetailsOfCart(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Get(CartId) };
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
