using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;
using Unit.Logic;

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

        public ResultViewModel AddUpdate(UpdatesViewModel model)
        {
            try
            {
                uintOfWork.updatess.Add(model);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Added successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Add New Update " };

            }
        }

        public ResultViewModel EditUpdate(UpdatesViewModel model)
        {
            try
            {
                uintOfWork.updatess.Edit(model);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Edited successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Edit an Update " };

            }
        }

        public ResultViewModel EditView(int id)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.updatess.EditView(id) };
            }

            
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr With View the update " };

            }
        }

        public ResultViewModel DeleteUpdate(int id)
        {
            try
            {
                uintOfWork.updatess.Remove(id);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Deleted successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Can not find This Id " };

            }
        }
    }
}
