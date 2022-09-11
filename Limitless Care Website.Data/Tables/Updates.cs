using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Updates
    {
        [Key]
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Brief { get; set; }
        public string Doumention { get; set; }
        public string BriefInArabic { get; set; }
        public string DoumentionInArabic { get; set; }
        public DateTime DateTime { get; set; }
    }
}
