using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Data
{
   public class Admin : IdentityUser
   {
        public string Name { get; set; }
        public string Nationality { get; set; }
   }
}
