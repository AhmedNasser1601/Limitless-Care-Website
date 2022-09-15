using Limitless_Care_Website.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class DetailsOfCartViewModel
    {
        public List<string> section1 { get; set; } 
        public List<string> section2 { get; set; }
        public List<string> section3 { get; set; } 
        public List<string> section4 { get; set; } 
        public List<Section5ViewModel> section5 { get; set; } 

  
    }
}