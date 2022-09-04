using Limitless_Care_Website.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
  public  class DetailsOfCartViewModelArabic
    {
        public string AcurrateFrequnentInArabic { get; set; }
        public string CustomerStatisfactionInArabic { get; set; }
        public List<string> Providers { get; set; }
        public List<string> Flexibilities { get; set; }
        public List<Digitalization> Digitalizations { get; set; }

    }
}
