using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;
using Unit.Logic;

namespace Limitless.Services.Services.PeopleServices
{
    public class PeopleServices : IPeopleServices
    {
        private readonly UintOfWork uintOfWork;
        public PeopleServices(ApplicationContext context)
        {
            this.uintOfWork = new UintOfWork(context);
        }
        public ResultViewModel GetPeoples()
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.peoples.Get() };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In Geting people In English " };
            }
        }
        public ResultViewModel GetPerson(int id)
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.peoples.Get(id) };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In Geting people with id "+id };
            }
        }
        public ResultViewModel GetPeoples_Ar()
        {
            try
            {
                return new ResultViewModel { IsSuccess = true, Data = uintOfWork.peoples.Get_Ar() };
            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Error In Geting people In Arabic " };
            }
        }

        public ResultViewModel AddPerson(PeopleViewModel model)
        {
            try
            {
                uintOfWork.peoples.Add(model);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Added successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Add New Request " };

            }
        }

        public ResultViewModel EditPerson(PeopleViewModel model)
        {
            try
            {
                uintOfWork.peoples.Edit(model);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Edited successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Edit This Person " };

            }
        }

        public ResultViewModel DeletePerson(int id)
        {
            try
            {
                uintOfWork.peoples.Remove(id);
                uintOfWork.Commit();
                return new ResultViewModel { IsSuccess = true, Message = "Deleted successfully " };

            }
            catch
            {
                return new ResultViewModel { IsSuccess = false, Message = "Erorr When Delete This Person " };

            }
        }
    }
}
