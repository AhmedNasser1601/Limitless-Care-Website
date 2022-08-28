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
        public int Details_ID { get; set; }
        [ForeignKey("Details_ID")]
        public DigitalizationDetails details { get; set; }

    }
}
