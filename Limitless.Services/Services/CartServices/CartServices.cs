using Limitless_Care_Website.Logic;
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
        private readonly IUnitOfWork uintOfWork;
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
        public ResultViewModel GetDetailsOfCartSec1(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Details1(CartId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting  Cart Of Id " + CartId };
            }
        }
        public ResultViewModel GetDetailsOfCartSec2(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.Details2(CartId) };
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

        public ResultViewModel AddRequest(RequestViewModel model)
        {
            try
            {
                uintOfWork.requests.Add(model);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Added successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Add New Request " };

            }
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

        public ResultViewModel GetDetailsOfCartSec1_Ar(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.DetailsSection1_Ar(CartId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting  Cart Of Id "+ CartId };
            }
        }
        public ResultViewModel GetDetailsOfCartSec2_Ar(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.DetailsSection2_Ar(CartId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting  Cart Of Id " + CartId };
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
