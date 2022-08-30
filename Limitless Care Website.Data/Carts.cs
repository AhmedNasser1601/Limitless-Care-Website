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
        public ICollection <Flexibility> flexibilities { get; set; }
        public ICollection<Providers> Providers { get; set; }
        public ICollection<Digitalization> digitalizations { get; set; }
        //public ICollection<DigitalizationDetails> DigitalizationDetails { get; set; }
        public ICollection<InPatient> inPatients { get; set; }
        public ICollection<OutPatient> outPatients { get; set; }
        public ICollection<Others> Others { get; set; }
        public ICollection<SpecialBenefits> SpecialBenefits { get; set; }






    }
}
