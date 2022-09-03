using Limitless_Care_Website.Data;
using Limitless_Care_Website.Logic.Models;
using LimitlessCareWebsite.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;

namespace Limitless_Care_Website.Logic.DataAcess
{
    public class RequestReposatoriy : Repository<Requests>
    {
        public RequestReposatoriy(ApplicationContext context) : base(context) { }
        public void Add(RequestViewModel model)
        {
            var data = new Requests
            {
                Id=0,
                UserName = model.UserName,
                Email = model.Email,
                Phone = model.Phone,
                CompanyName = model.CompanyName
            };
            Insert(data);

        }

    }
}
