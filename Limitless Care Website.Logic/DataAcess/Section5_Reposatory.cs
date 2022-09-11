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
        public IEnumerable<Section5ViewModel> GetDetails(int CartId)
        {
            var model =  AsQueryable().Where(w => w.Id == CartId).Select(s=> new Section5ViewModel
            {
                Brief = s.Brief,
                section5Details=s.section5Details.Select(s=>s.Detail).ToList()
            }
              
            );
            return model;
        }
        public IEnumerable<Section5ViewModel> GetDetails_Ar(int CartId)
        {
            var model = AsQueryable().Where(w => w.Id == CartId).Select(s => new Section5ViewModel
            {
                Brief = s.BriefInArabic,
                section5Details = s.section5Details.Select(s => s.DetailInArabic).ToList()
            }

            );
            return model;
        }
    }
}
