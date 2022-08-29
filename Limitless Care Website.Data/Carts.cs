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

        public int Flexibility_ID { get; set; }
        [ForeignKey("Flexibility_ID")]

        public Flexibility flexibility { get; set; }

        public int Digitalization_ID { get; set; }
        [ForeignKey("Digitalization_ID")]

        public Digitalization digitalization { get; set; }

        public int Providers_ID { get; set; }
        [ForeignKey("Providers_ID")]

        public Providers providers { get; set; }

        public int Benefits_ID { get; set; }
        [ForeignKey("Benefits_ID")]


        public Benefits benefits { get; set; }












    }
}
