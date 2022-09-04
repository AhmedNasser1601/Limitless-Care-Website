using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Providers
    {
        [Key]
        public int Id { get; set; }
        public string DetailInArabic { get; set; }
        public string Detail { get; set; }
        public int Cart_id { get; set; }
        [ForeignKey("Cart_id")]
        [Required]

        public Carts Carts { get; set; }
    }
}
