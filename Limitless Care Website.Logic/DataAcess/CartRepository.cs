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
                Doumention = s.Doumention,
                IconPath = s.IconPath

            });
            return model;

        } // Get All Carts For Home Page
        public IEnumerable<SectionsNameViewModel> SectionsName(int id)
        {

            var model = AsQueryable().Where(w => w.Id == id).Select(s => new SectionsNameViewModel
            {
                Sections = new List<string> {
                   s.NameofSection1,
                   s.NameofSection2,
                   s.NameofSection3,
                   s.NameofSection4,
                   s.NameofSection5
                }      
            });
            return model;

        } // Get Names Of Sections In specific Cart
        public IEnumerable<MainOfCartViewModel> Details1(int id)
        {

            var model = AsQueryable().Where(w => w.Id == id).Select(s => new MainOfCartViewModel
            {
                Id = s.Id,
                Name = s.Name,
                ImagePath = s.ImagePath,
                Brief = s.Brief,
                Doumention = s.Doumention,
                IconPath = s.IconPath
            });
            return model;

        }  // Get Details Of First Part In Cart Page 
        public IEnumerable<DetailsOfCartViewModel> Details2(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new DetailsOfCartViewModel
            {
                section1 = s.Section1.Select(h => h.Detail).ToList(),
                section2 = s.Section2.Select(h => h.Detail).ToList(),
                section3 = s.Section3.Select(h => h.Detail).ToList(),
                section4 = s.Section4.Select(h => h.Detail).ToList(),
                section5 = uintOfWork.Digitalizations.GetDetails(id).ToList()
            });
        }  // Get Details Of Second Part In Cart Page 
        public IEnumerable<BenefitsOfCartViewModel> Benefits(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new BenefitsOfCartViewModel
            {
                InPatients = s.InPatients.Select(h=>h.Detail).ToList(),
                OutPatients = s.OutPatients.Select(j => j.Detail).ToList(),
                Others = s.Others.Select(i => i.Detail).ToList(),
                SpecialBenefits = s.SpecialBenefits.Select(q => q.Detail).ToList()

            });

        } // Get Details Of Thired Part In Cart Page 
        // Get Data In Arabic 
        public IEnumerable<MainOfCartViewModel> Main_Ar()
        {

            var model = AsQueryable().Select(s => new MainOfCartViewModel
            {
                Id = s.Id,
                Name = s.NameInArabic,
                ImagePath = s.ImagePath,
                Brief= s.BriefInArabic,
                Doumention = s.DoumentionInArabic,
                IconPath = s.IconPath


            });
            return model;

        }
        public IEnumerable<SectionsNameViewModel> SectionsName_Ar(int id)
        {

            var model = AsQueryable().Where(w => w.Id == id).Select(s => new SectionsNameViewModel
            {
                Sections = new List<string> {
                   s.NameofSection1_Ar,
                    s.NameofSection2_Ar,
                   s.NameofSection3_Ar,
                  s.NameofSection4_Ar,
                   s.NameofSection5_Ar
                   }
            }) ;
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
                Doumention=s.DoumentionInArabic,
                IconPath =s.IconPath


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
                section5 = uintOfWork.Digitalizations.GetDetails_Ar(id).ToList()
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
        //Admin Tool 
        public void Add (CartViewModel model)
        {
            var data = new Carts
            {
                Id = model.Id,
                Name = model.Name,
                NameInArabic = model.NameInArabic,
                Brief = model.Brief,
                BriefInArabic = model.BriefInArabic,
                ImagePath = model.ImagePath,
                Doumention = model.Doumention,
                DoumentionInArabic = model.DoumentionInArabic,
                NameofSection1 = model.NameofSection1,
                NameofSection1_Ar =model.NameofSection1_Ar,

                NameofSection2 = model.NameofSection2,
                NameofSection2_Ar = model.NameofSection2_Ar,

                NameofSection3 = model.NameofSection3,
                NameofSection3_Ar = model.NameofSection3_Ar,

                NameofSection4 = model.NameofSection4,
                NameofSection4_Ar = model.NameofSection4_Ar,

                NameofSection5 = model.NameofSection5,
                NameofSection5_Ar = model.NameofSection5_Ar,
                Section1 = model.Section1?.Select(s=>new Section1
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic,
                    Carts = null
                 
                }).ToList(),
                Section2 = model.Section2?.Select(s => new Section2
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic

                }).ToList(),
                Section3 = model.Section3?.Select(s => new Section3
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic

                }).ToList(),
                Section4 = model.Section4?.Select(s => new Section4
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic

                }).ToList(),
                Section5 = model.Section5?.Select(s => new Section5
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Brief = s.Brief,
                    BriefInArabic = s.BriefInArabic,
                    section5Details = s.section5Details?.Select(h=> new Section5Details
                    {
                        Id = h.Id,
                        Detail = h.Detail,
                        DetailInArabic = h.DetailInArabic,
                        Digitalization_ID = s.Id
                    }).ToList()      
                }).ToList(),
                InPatients = model.InPatients?.Select(s => new InPatient
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic

                }).ToList(),
                OutPatients = model.OutPatients?.Select(s => new OutPatient
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic

                }).ToList(),
                Others = model.Others?.Select(s => new Others
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic

                }).ToList(),
                SpecialBenefits = model.SpecialBenefits?.Select(s => new SpecialBenefits
                {
                    Id = s.Id,
                    Cart_id = model.Id,
                    Detail = s.Detail,
                    DetailInArabic = s.DetailInArabic

                }).ToList()
            };
            Insert(data);
        }  // Adding A new Cart  
        public void EditMain (CartViewModel model)
        {
            var data = new Carts
            {
                Id = model.Id,
                Name = model.Name,
                NameInArabic = model.NameInArabic,
                Brief = model.Brief,
                BriefInArabic = model.BriefInArabic,
                ImagePath = model.ImagePath,
                Doumention = model.Doumention,
                DoumentionInArabic = model.DoumentionInArabic,
                IconPath = model.IconPath
            };
            Update(data);
        } //Edit the First Part In Cart Page
        //public void EditSections(CartViewModel model, IEnumerable<SectionsViewModel> model1)
        //{
        //    var data = new Carts
        //    {
        //        Id = model.Id,
        //        NameofSection1 = model.NameofSection1,
        //        NameofSection1_Ar = model.NameofSection1_Ar,
        //        NameofSection2 = model.NameofSection2,
        //        NameofSection2_Ar = model.NameofSection2_Ar,
        //        NameofSection3 = model.NameofSection3,
        //        NameofSection3_Ar = model.NameofSection3_Ar,
        //        NameofSection4 = model.NameofSection4,
        //        NameofSection4_Ar = model.NameofSection4_Ar,
        //        NameofSection5 = model.NameofSection5,
        //        NameofSection5_Ar = model.NameofSection5_Ar,
        //        Section1 = model.Section1.Select(s => new Section1
        //        {
        //            Id = s.Id,
        //            Cart_id = model.Id,
        //            Detail = s.Detail,
        //            DetailInArabic = s.DetailInArabic,
        //        }).ToList(),
        //        Section2 = model.Section2.Select(s => new Section2
        //        {
        //            Id = s.Id,
        //            Cart_id = model.Id,
        //            Detail = s.Detail,
        //            DetailInArabic = s.DetailInArabic

        //        }).ToList(),
        //        Section3 = model.Section3.Select(s => new Section3
        //        {
        //            Id = s.Id,
        //            Cart_id = model.Id,
        //            Detail = s.Detail,
        //            DetailInArabic = s.DetailInArabic

        //        }).ToList(),
        //        Section4 = model.Section4.Select(s => new Section4
        //        {
        //            Id = s.Id,
        //            Cart_id = model.Id,
        //            Detail = s.Detail,
        //            DetailInArabic = s.DetailInArabic

        //        }).ToList(),
        //        //Section5 = model.Section5.Where(q => q.Cart_id == model.Id).Select(s => new Section5
        //        //{
        //        //    Id = s.Id,
        //        //    Cart_id = model.Id,
        //        //    Brief = s.Brief,
        //        //    BriefInArabic = s.BriefInArabic,
        //        //    section5Details = s.section5Details?.Where(q => q.Digitalization_ID == s.Id).Select(h => new Section5Details
        //        //    {
        //        //        Id = 0,
        //        //        Detail = h.Detail,
        //        //        DetailInArabic = h.DetailInArabic,
        //        //        Digitalization_ID = s.Id
        //        //    }).ToList()
        //        //}).ToList(),
        //    };
        //    int s;
        //    Update(data);
        //}
        public void Remove(int id)
        {
            var data = AsQueryable().Where(w => w.Id == id).FirstOrDefault();
            Delete(data);
        } // Deleting a specific Cart



    }
}

