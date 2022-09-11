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
    public class Section5_DetailsReposatory : Repository<Section5Details>
    {
        private readonly UintOfWork uintOfWork;

        public Section5_DetailsReposatory(ApplicationContext context) : base(context)
        {
            this.uintOfWork = new UintOfWork(context);
        }
        //public IEnumerable<Section5> GetDetails(int CartId)
        //{
        //    var Data = uintOfWork.Digitalizations.GetDetails(CartId).FirstOrDefault();
        //    Data.section5Details = AsQueryable().Where(s => s.Digitalization_ID == Data.Id) .ToList();
        //    yield return Data;
        //}
    }
}
