using Limitless_Care_Website.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class DetailsOfCartViewModel
    {
        public string AcurrateFrequnent { get; set; }
        public string CustomerStatisfaction { get; set; }
        public List<Providers> Providers { get; set; }
        public List<Flexibility> Flexibilities { get; set; }
        public List<Digitalization> Digitalizations { get; set; }
  
    }
}
