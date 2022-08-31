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
    public class CartRepository : Repository<Carts>
    {
       private readonly UintOfWork uintOfWork;
        public CartRepository(ApplicationContext context) : base(context)
        {
            this.uintOfWork = new UintOfWork(context);

        }
        public IEnumerable<CartViewModel> Get(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new CartViewModel
            {
                Name = s.Name,
                ImagePath = s.ImagePath,
                Brief = s.Brief,
                Doumention = s.Doumention,
                AcurrateFrequnent = s.AcurrateFrequnent,
                CustomerStatisfaction = s.CustomerStatisfaction,
                Flexibilities = s.Flexibilities.ToList(),
                Providers = s.Providers.ToList(),
                Digitalizations = uintOfWork.Digitalization.GetDigitalizations(id).ToList(),
                InPatients = s.InPatients.ToList(),
                OutPatients = s.OutPatients.ToList(),
                Others = s.Others.ToList(),
                SpecialBenefits = s.SpecialBenefits.ToList()

            }); 

        }
    
    }
}
