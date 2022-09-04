using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Carts
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Brief { get; set; }
        public string Doumention { get; set; }
        public string AcurrateFrequnent { get; set; }
        public string CustomerStatisfaction { get; set; }
        public string NameInArabic { get; set; }
        public string BriefInArabic { get; set; }
        public string DoumentionInArabic { get; set; }
        public string AcurrateFrequnentInArabic { get; set; }
        public string CustomerStatisfactionInArabic { get; set; }
        public ICollection <Flexibility> Flexibilities { get; set; }
        public ICollection<Providers> Providers { get; set; }
        public ICollection<Digitalization> Digitalizations { get; set; }
        //public ICollection<DigitalizationDetails> DigitalizationDetails { get; set; }
        public ICollection<InPatient> InPatients { get; set; }
        public ICollection<OutPatient> OutPatients { get; set; }
        public ICollection<Others> Others { get; set; }
        public ICollection<SpecialBenefits> SpecialBenefits { get; set; }







    }
}
