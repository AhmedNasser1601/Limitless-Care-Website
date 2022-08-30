using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class InPatient
    {
        [Key]
        public int Id { get; set; }
        public string Detail { get; set; }
        public int cart_id { get; set; }
        [ForeignKey("cart_id")]
        [Required]
        public Carts Carts { get; set; }

    }
}
