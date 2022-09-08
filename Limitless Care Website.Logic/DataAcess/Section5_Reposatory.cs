using Limitless_Care_Website.Data;
using Limitless_Care_Website.Logic.Models;
using LimitlessCareWebsite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit.Data;
using Unit.Logic;

namespace Limitless_Care_Website.Logic.DataAcess
{
    public class Section5_Reposatory : Repository<Section5>
    {
        public Section5_Reposatory(ApplicationContext context) : base(context) { }
        public IEnumerable< Section5> GetDetails(int CartId)
        {
            var model =  AsQueryable().Where(w => w.Id == CartId).ToList();
            return model;
        }
    }
}
