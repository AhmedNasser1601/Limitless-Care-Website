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

        public IEnumerable<UpdatesViewModel> Main()
        {

            var model = AsQueryable().Select(s => new UpdatesViewModel
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
                Doumention = s.Doumention
            });

        }
    }
}
