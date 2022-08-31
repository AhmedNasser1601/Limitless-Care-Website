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
    public class DigitalizationReposatory : Repository<Digitalization>
    {
        public DigitalizationReposatory(ApplicationContext context) : base(context) { }
        public IEnumerable< Digitalization> GetDetails(int CartId)
        {
            var model =  AsQueryable().Where(w => w.Id == CartId).ToList();
            return model;
        }
    }
}
