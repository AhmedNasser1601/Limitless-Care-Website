using Limitless_Care_Website.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string IconPath { get; set; }
        public string Brief { get; set; }
        public string Doumention { get; set; }
        public string NameInArabic { get; set; }
        public string BriefInArabic { get; set; }
        public string DoumentionInArabic { get; set; }
        public string NameofSection1 { get; set; }
        public string NameofSection2 { get; set; }
        public string NameofSection3 { get; set; }
        public string NameofSection4 { get; set; }
        public string NameofSection5 { get; set; }
        public string NameofSection1_Ar { get; set; }
        public string NameofSection2_Ar { get; set; }
        public string NameofSection3_Ar { get; set; }
        public string NameofSection4_Ar { get; set; }
        public string NameofSection5_Ar { get; set; }

        public ICollection<Section1> Section1 { get; set; }
        public ICollection<Section2> Section2 { get; set; }
        public ICollection<Section3> Section3 { get; set; }
        public ICollection<Section4> Section4 { get; set; }
        public ICollection<Section5> Section5 { get; set; }

        public ICollection<InPatient> InPatients { get; set; }
        public ICollection<OutPatient> OutPatients { get; set; }
        public ICollection<Others> Others { get; set; }
        public ICollection<SpecialBenefits> SpecialBenefits { get; set; }
    }
}
