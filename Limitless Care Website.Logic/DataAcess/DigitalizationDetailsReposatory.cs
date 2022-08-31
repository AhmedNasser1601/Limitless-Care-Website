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
    public class DigitalizationDetailsReposatory : Repository<DigitalizationDetails>
    {
        private readonly UintOfWork uintOfWork;

        public DigitalizationDetailsReposatory(ApplicationContext context) : base(context)
        {
            this.uintOfWork = new UintOfWork(context);
        }
        public IEnumerable<Digitalization> GetDigitalizations(int CartId)
        {
            var Data = uintOfWork.Digitalizations.GetDetails(CartId).FirstOrDefault();
            Data.DigitalizationDetails = AsQueryable().Where(s => s.Digitalization_ID == Data.Id) .ToList();
            yield return Data;
        }
    }
}
