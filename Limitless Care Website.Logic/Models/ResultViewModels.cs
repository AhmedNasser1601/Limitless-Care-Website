using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class ResultViewModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
