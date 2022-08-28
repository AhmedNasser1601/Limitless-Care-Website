using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Others
    {
        [Key]
        public int Id { get; set; }
        public string Detail { get; set; }
    }
}
