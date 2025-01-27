﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Section5Details
    {
        [Key]
        public int Id { get; set; }
        
        public string Detail { get; set; }
        public string DetailInArabic { get; set; }

        public int Digitalization_ID { get; set; }
        [ForeignKey("Digitalization_ID")]
      //  [Required]
        public Section5 Digitalization { get; set; }

    }
}
