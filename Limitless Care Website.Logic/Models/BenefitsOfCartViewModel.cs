using Limitless_Care_Website.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class BenefitsOfCartViewModel
    {
        public List<string> InPatients { get; set; }
        public List<string> OutPatients { get; set; }
        public List<string> Others { get; set; }
        public List<string> SpecialBenefits { get; set; }

    }
}
