using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Digitalization
    {
        [Key]
        public int Id { get; set; }
        public string Brief { get; set; }

        [ForeignKey("Details_ID")]
        public int Details_ID { get; set; }
        public DigitalizationDetails DigitalizationDetails { get; set; }

    }
}
