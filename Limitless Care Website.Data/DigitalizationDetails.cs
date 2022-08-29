using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class DigitalizationDetails
    {
        [Key]
        public int Id { get; set; }
        public string Detail { get; set; }
        //public Digitalization Digitalization { get; set; }

    }
}
