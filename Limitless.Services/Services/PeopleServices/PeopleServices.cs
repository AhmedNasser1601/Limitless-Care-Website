using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;
using Unit.Logic;
using Unit.Logic.Models;

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
    }
}
