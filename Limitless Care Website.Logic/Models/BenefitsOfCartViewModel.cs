using Limitless_Care_Website.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class BenefitsOfCartViewModel
    {
        public List<InPatient> InPatients { get; set; }
        public List<OutPatient> OutPatients { get; set; }
        public List<Others> Others { get; set; }
        public List<SpecialBenefits> SpecialBenefits { get; set; }

    }
}
