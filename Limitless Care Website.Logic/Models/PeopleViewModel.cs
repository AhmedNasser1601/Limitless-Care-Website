using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class PeopleViewModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string NameInArabic { get; set; }
        public string RoleInArabic { get; set; }
    }
}
