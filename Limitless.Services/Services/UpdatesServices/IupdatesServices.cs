using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless.Services.Services.UpdatesServices
{
  public interface IupdatesServices
    {
        public ResultViewModel GetMainUpdates();
        public ResultViewModel GetDetailsOfUpdates(int DetailId);
        public ResultViewModel GetMainUpdates_Ar();
        public ResultViewModel GetDetailsOfUpdates_Ar(int DetailId);
        public ResultViewModel AddUpdate(UpdatesViewModel model);
        public ResultViewModel EditUpdate(UpdatesViewModel model);
        public ResultViewModel EditView(int id);
        public ResultViewModel DeleteUpdate(int id);

    }
}
