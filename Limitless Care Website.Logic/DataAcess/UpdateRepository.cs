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
    public class UpdateRepository : Repository<Updates>
    {
        public UpdateRepository(ApplicationContext context) : base(context) { }

        //Get Data Of Updates In English 
        public IEnumerable<MainUpdatesViewModel> Main()
        {

            var model = AsQueryable().Select(s => new MainUpdatesViewModel
            {
                Id = s.Id,
                ImagePath = s.ImagePath,
                Brief = s.Brief
            });
            return model;

        }
        public IEnumerable<UpdatesViewModel> Details(int id)
        {
        
               return AsQueryable().Where(w => w.Id == id).Select(s => new UpdatesViewModel
                {
                    ImagePath = s.ImagePath,
                    Brief = s.Brief,
                    Doumention = s.Doumention,

                });
         
        }
        //Get Data Of Updates In Arabic
        public IEnumerable<MainUpdatesViewModel> Main_Ar()
        {

            var model = AsQueryable().Select(s => new MainUpdatesViewModel
            {
                Id = s.Id,
                ImagePath = s.ImagePath,
                Brief = s.BriefInArabic
            });
            return model;

        }
        public IEnumerable<UpdatesViewModel> Details_Ar(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new UpdatesViewModel
            {
                ImagePath = s.ImagePath,
                Brief = s.BriefInArabic,
                Doumention = s.DoumentionInArabic
            });

        }

        public void Add(UpdatesViewModel model)
        {
            var data = new Updates
            {
                Id = 0,
                Brief = model.Brief,
                BriefInArabic =model.BriefInArabic,
                DateTime =model.DateTime,
                Doumention=model.Doumention,
                DoumentionInArabic = model.DoumentionInArabic,
                ImagePath = model.ImagePath
            
            };
            Insert(data);
        }
        public void Edit(UpdatesViewModel model)
        {
            var data = new Updates
            {
                Id = model.Id,
                Brief = model.Brief,
                BriefInArabic = model.BriefInArabic,
                DateTime = model.DateTime,
                Doumention = model.Doumention,
                DoumentionInArabic = model.DoumentionInArabic,
                ImagePath = model.ImagePath
            };
            Update(data);
        }
        public IEnumerable<UpdatesViewModel> EditView(int id)
        {
            return AsQueryable().Where(w => w.Id == id).Select(s => new UpdatesViewModel
            {
                Id = s.Id,
                Brief = s.Brief,
                BriefInArabic = s.BriefInArabic,
                DateTime = s.DateTime,
                Doumention = s.Doumention,
                DoumentionInArabic = s.DoumentionInArabic,
                ImagePath = s.ImagePath

            });

        }
        public void Remove(int id)
        {
            var data = AsQueryable().Where(w => w.Id == id).FirstOrDefault();
            Delete(data);
        }
     
    }
}
