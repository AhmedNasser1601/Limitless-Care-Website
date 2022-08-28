using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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












    }
}
