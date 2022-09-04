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
        #region English
        public ResultViewModel GetMainCart()
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Main() };
            }
            catch
            {
                throw new Exception();
            }
        }
        public ResultViewModel GetDetailsOfCart(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Details(CartId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting  Cart Of Id " + CartId };
            }
        }
        public ResultViewModel GetBenefitsOfCart(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Benefits(CartId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting Beneifts" };
            }
        }
        #endregion

        public void AddRequest(RequestViewModel model)
        {
            uintOfWork.requests.Add(model);
            uintOfWork.Commit();
        }
        #region Arabic
        public ResultViewModel GetMainCart_Ar()
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Main_Ar() };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting All Carts" };
            }
        }

        public ResultViewModel GetDetailsOfCart_Ar(int id)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Details_Ar(id) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting  Cart Of Id "+id };
            }
        }

        public ResultViewModel GetBenefitsOfCart_Ar(int CartId)
        {
            try
            {
                    return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Benefits_Ar(CartId) };
            }         
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting Ar Beneifts" };
            }
        }
        #endregion
    }
}
