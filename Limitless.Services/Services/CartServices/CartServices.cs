using Limitless_Care_Website.Logic;
using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;
using Unit.Logic;

namespace Limitless.Services.Services.CartServices
{
    public class CartServices : ICartServices
    {
        private readonly IUnitOfWork uintOfWork;
        public CartServices(ApplicationContext context)
        {
            this.uintOfWork = new UintOfWork(context);
        }
       //Get Data In English
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
        public ResultViewModel GetSectionsName(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.SectionsName(CartId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting Sections Name for Cart Of Id " + CartId };
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
     
        //Get Data In Arabic
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
        public ResultViewModel GetSectionsName_Ar(int CartId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.Cart.SectionsName_Ar(CartId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting Sections Name for Cart Of Id " + CartId };
            }
        }

        //Add New Request
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

        //Admin Tool
        public ResultViewModel AddCart(CartViewModel model)
        {
            try
            {
                uintOfWork.Cart.Add(model);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Added successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Add New Cart " };

            }
        }
        public ResultViewModel EditMain(CartViewModel model)
        {
            try
            {
                uintOfWork.Cart.EditMain(model);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Edited successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Edit Main Cart " };

            }
        }
        public ResultViewModel DeleteCart(int id)
        {
            try
            {
                uintOfWork.Cart.Remove(id);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Deleted successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Delete This Cart With id "+id };

            }
        }

        public ResultViewModel GetRequests()
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.requests.Get() };
            }
            catch
            {
                throw new Exception();
            }
        }
        //public ResultViewModel EditSections(CartViewModel model,int id)
        //{
        //    try
        //    {
        //        //uintOfWork.Cart.EditSections(model,id);
        //        //uintOfWork.Commit();
        //        var data = uintOfWork.Cart.GetIds(id);
        //        uintOfWork.Cart.EditSections(model,data);
        //        return new ResultViewModel { IsSuccess = true, Message = "Edited successfully " };

        //    }
        //    catch
        //    {
        //        return new ResultViewModel { IsSuccess = false, Message = "Erorr When Edit Main Cart " };

        //    }
        //}


    }
}
