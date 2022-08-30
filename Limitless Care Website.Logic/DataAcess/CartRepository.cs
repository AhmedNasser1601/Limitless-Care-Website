using Limitless_Care_Website.Data;
using Limitless_Care_Website.Logic.Models;
using LimitlessCareWebsite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit.Data;

namespace Limitless_Care_Website.Logic.DataAcess
{
    public class CartRepository : Repository<Carts>
    {
        public CartRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<CartViewModel> Get(int id)
        {
            //select * from product
            return AsQueryable().Where(w => w.Id == id).Select(s => new CartViewModel
            {
                Name = s.Name,
                ImagePath = s.ImagePath,
                Brief = s.Brief,
                Doumention = s.Doumention,
                AcurrateFrequnent = s.AcurrateFrequnent,
                CustomerStatisfaction = s.CustomerStatisfaction,
                Flexibilities = s.flexibilities.ToList(),
                providers = s.Providers.ToList(),
                digitalizations = s.digitalizations.ToList(),
                //DigitalizationDetails = n
                inPatients = s.inPatients.ToList(),
                outPatients = s.outPatients.ToList(),
                Others = s.Others.ToList(),
                SpecialBenefits = s.SpecialBenefits.ToList()

            }) ;  //gets a list of my products as product view models

        }
    
    }
}
