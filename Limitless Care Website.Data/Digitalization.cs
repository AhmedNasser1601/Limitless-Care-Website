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
        public string BriefInArabic { get; set; }
        public string Brief { get; set; }
        public List<DigitalizationDetails> DigitalizationDetails { get; set; }
        public int Cart_id { get; set; }
        [ForeignKey("Cart_id")]
        [Required]
        public Carts Carts { get; set; }

    }
}
