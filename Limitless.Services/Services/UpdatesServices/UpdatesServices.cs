using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;
using Unit.Logic;
using Unit.Logic.Models;

namespace Limitless.Services.Services.UpdatesServices
{
   public class UpdatesServices : IupdatesServices
    {
        private readonly UintOfWork uintOfWork;
        public UpdatesServices(ApplicationContext context)
        {
            this.uintOfWork = new UintOfWork(context);
        }
        public ResultViewModel GetMainUpdates()
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.updatess.Main() };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting All Details" };
            }
        }
        public ResultViewModel GetDetailsOfUpdates(int DetailId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.updatess.Details(DetailId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In Geting the Detail Of Id  "+ DetailId };
            }
        }

        public ResultViewModel GetMainUpdates_Ar()
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.updatess.Main_Ar() };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In geting All Details" };
            }
        }

        public ResultViewModel GetDetailsOfUpdates_Ar(int DetailId)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.updatess.Details_Ar(DetailId) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In Geting the Detail Of Id  " + DetailId };
            }
        }
    }
}
