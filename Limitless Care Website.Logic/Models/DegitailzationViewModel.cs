using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class DegitailzationViewModel
    {
        public int Id { get; set; }
        //public string BriefInArabic { get; set; }
        public string Brief { get; set; }
        public IEnumerable<string> DigitalizationDetails { get; set; }
    }
}
