using System;
using System.Collections.Generic;
using System.Text;
using Unit.Logic.Models;

namespace Limitless.Services.Services.UpdatesServices
{
  public interface IupdatesServices
    {
        public ResultViewModel GetMainUpdates();
        public ResultViewModel GetDetailsOfUpdates(int DetailId);
    }
}
