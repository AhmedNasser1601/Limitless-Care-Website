using System;
using System.Collections.Generic;
using System.Text;
using Unit.Logic.Models;

namespace Limitless.Services.Services.PeopleServices
{
    public  interface IPeopleServices
    {
        public ResultViewModel GetPeoples();
        public ResultViewModel GetPeoples_Ar();
    }
}
