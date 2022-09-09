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
        // Get Data In English 
        public IEnumerable<MainOfCartViewModel> Main()
        {
            
            var model=  AsQueryable().Select(s => new MainOfCartViewModel
            {
                Id = s.Id,
                Name = s.Name,
                ImagePath = s.ImagePath,
                Brief = s.Brief,
                Doumention = s.Doumention
            });
            return model;

        }
        public IEnumerable<SectionsNameViewModel> SectionsName(int id)
        {

            var model = AsQueryable().Where(w => w.Id == id).Select(s => new SectionsNameViewModel
            {
              NameofSection1 = s.NameofSection1,
              NameofSection2 = s.NameofSection2,
              NameofSection3 = s.NameofSection3,
              NameofSection4 = s.NameofSection4,
              NameofSection5 = s.NameofSection5
            });
            return model;

        }
        public IEnumerable<MainOfCartViewModel> Details1(int id)
        {

            var model = AsQueryable().Where(w => w.Id == id).Select(s => new MainOfCartViewModel
            {
                Id = s.Id,
                Name = s.Name,
                ImagePath = s.ImagePath,
                Brief = s.Brief,
                Doumention = s.Doumention
            });
            return model;

        }
        public IEnumerable<DetailsOfCartViewModel> Details2(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new DetailsOfCartViewModel
            {
                section1 = s.Section1.Select(h => h.Detail).ToList(),
                section2 = s.Section2.Select(h => h.Detail).ToList(),
                section3 = s.Section3.Select(h => h.Detail).ToList(),
                section4 = s.Section4.Select(h => h.Detail).ToList(),
                section5 = uintOfWork.Digitalization.GetDetails(id).ToList()
            }); 
        }
        public IEnumerable<BenefitsOfCartViewModel> Benefits(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new BenefitsOfCartViewModel
            {
                InPatients = s.InPatients.Select(h=>h.Detail).ToList(),
                OutPatients = s.OutPatients.Select(j => j.Detail).ToList(),
                Others = s.Others.Select(i => i.Detail).ToList(),
                SpecialBenefits = s.SpecialBenefits.Select(q => q.Detail).ToList()

            });

        }
        // Get Data In Arabic 
        public IEnumerable<MainOfCartViewModel> Main_Ar()
        {

            var model = AsQueryable().Select(s => new MainOfCartViewModel
            {
                Id = s.Id,
                Name = s.NameInArabic,
                ImagePath = s.ImagePath,
                Brief= s.BriefInArabic,
                Doumention = s.DoumentionInArabic


            });
            return model;

        }
        public IEnumerable<SectionsNameViewModel> SectionsName_Ar(int id)
        {

            var model = AsQueryable().Where(w => w.Id == id).Select(s => new SectionsNameViewModel
            {
                NameofSection1 = s.NameofSection1_Ar,
                NameofSection2 = s.NameofSection2_Ar,
                NameofSection3 = s.NameofSection3_Ar,
                NameofSection4 = s.NameofSection4_Ar,
                NameofSection5 = s.NameofSection5_Ar
            });
            return model;

        }
        public IEnumerable<MainOfCartViewModel> DetailsSection1_Ar(int id)
        {

            var model = AsQueryable().Where(w => w.Id == id).Select(s => new MainOfCartViewModel
            {
                Id = s.Id,
                Name = s.NameInArabic,
                ImagePath = s.ImagePath,
                Brief = s.BriefInArabic,
                Doumention=s.DoumentionInArabic


            });
            return model;

        }
        public IEnumerable<DetailsOfCartViewModel> DetailsSection2_Ar(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new DetailsOfCartViewModel
            {
                section1 = s.Section1.Select(h => h.DetailInArabic).ToList(),
                section2 = s.Section2.Select(h => h.DetailInArabic).ToList(),
                section3 = s.Section3.Select(h => h.DetailInArabic).ToList(),
                section4 = s.Section4.Select(h => h.DetailInArabic).ToList(),
                section5 = uintOfWork.Digitalization.GetDetails(id).ToList()
            });

        }
        public IEnumerable<BenefitsOfCartViewModel> Benefits_Ar(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new BenefitsOfCartViewModel
            {
                InPatients = s.InPatients.Select(h => h.DetailInArabic).ToList(),
                OutPatients = s.OutPatients.Select(j => j.DetailInArabic).ToList(),
                Others = s.Others.Select(i => i.DetailInArabic).ToList(),
                SpecialBenefits = s.SpecialBenefits.Select(q => q.DetailInArabic).ToList()

            });

        }





    }
}

