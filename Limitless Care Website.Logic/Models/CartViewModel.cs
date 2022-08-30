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
        public string Brief { get; set; }
        public string Doumention { get; set; }
        public string AcurrateFrequnent { get; set; }
        public string CustomerStatisfaction { get; set; }
        public List <Providers> providers { get; set; }
        public List <Flexibility> Flexibilities { get; set; }
        public List <Digitalization> digitalizations { get; set; }
        public List<DigitalizationDetails> DigitalizationDetails { get; set; }
        public List<InPatient> inPatients { get; set; }
        public List<OutPatient> outPatients { get; set; }
        public List<Others> Others { get; set; }
        public List<SpecialBenefits> SpecialBenefits { get; set; }
    }
}
