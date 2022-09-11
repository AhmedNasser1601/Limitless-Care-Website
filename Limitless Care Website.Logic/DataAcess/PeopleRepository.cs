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

        }
        public IEnumerable<PeopleViewModel> Get(int id)
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
        }
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
        }
        public void Remove(int id)
        {
            var data = AsQueryable().Where(w => w.Id == id).FirstOrDefault();
            Delete(data);
        }
    }
}
