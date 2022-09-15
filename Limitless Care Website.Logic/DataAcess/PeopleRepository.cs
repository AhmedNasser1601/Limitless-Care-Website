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
    public class PeopleRepository : Repository<Peoples>
    {
        public PeopleRepository(ApplicationContext context) : base(context) { }
        // Get Data In English
        public IEnumerable<PeopleViewModel> Get()
        {

            var model = AsQueryable().Select(s => new PeopleViewModel
            {
                Id = s.Id,
                ImagePath = s.ImagePath,
                Role = s.Role,
                Name = s.Name
      
                
            });
            return model;

        } // Show All peoples 
        // Get Data In Arabic
        public IEnumerable<PeopleViewModel> Get_Ar()
        {

            var model = AsQueryable().Select(s => new PeopleViewModel
            {
                Id = s.Id,
                ImagePath = s.ImagePath,
                Role = s.RoleInArabic,
                Name = s.NameInArabic
            });
            return model;

        }
        public IEnumerable<PeopleViewModel> Get(int id) //Show a specific Person To Edit On It 
        { 

            var model = AsQueryable().Where(w=>w.Id==id).Select(s => new PeopleViewModel
            {
                Id = s.Id,
                ImagePath = s.ImagePath,
                Role = s.Role,
                Name = s.Name,
                NameInArabic = s.NameInArabic,
                RoleInArabic = s.RoleInArabic
            });
            return model;

        }
     
        public void Add(PeopleViewModel model)
        {
            var data = new Peoples
            {
                Id = 0,
                Name = model.Name,
                NameInArabic = model.NameInArabic,
                ImagePath = model.ImagePath,
                Role = model.Role,
                RoleInArabic = model.RoleInArabic   
            };
            Insert(data);
        } //Adding Anew Person 
        public void Edit(PeopleViewModel model)
        {
            var data = new Peoples
            {
                Id = model.Id,
                Name = model.Name,
                NameInArabic = model.NameInArabic,
                ImagePath = model.ImagePath,
                Role = model.Role,
                RoleInArabic = model.RoleInArabic
            };
            Update(data);
        } //Edit On Apesron 
        public void Remove(int id)
        {
            var data = AsQueryable().Where(w => w.Id == id).FirstOrDefault();
            Delete(data);
        } // Remone a specific Person
    }
}
