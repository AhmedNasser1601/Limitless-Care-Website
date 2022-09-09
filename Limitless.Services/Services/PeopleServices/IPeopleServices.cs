using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless.Services.Services.PeopleServices
{
    public  interface IPeopleServices
    {
        public ResultViewModel GetPeoples();
        public ResultViewModel GetPerson(int id);
        public ResultViewModel GetPeoples_Ar();
        public ResultViewModel AddPerson(PeopleViewModel model);
        public ResultViewModel EditPerson(PeopleViewModel model);
        public ResultViewModel DeletePerson(int id);

    }
}
