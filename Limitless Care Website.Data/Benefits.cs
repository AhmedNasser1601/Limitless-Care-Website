using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Limitless_Care_Website.Data
{
    internal class Benefits
    {
        [Key]
        public int Id { get; set; }
        public int InPatientId { get; set; }
        public int OutPatientId { get; set; }
        public int OthersId { get; set; }
        public int SpecialBenefitsId { get; set; }
    }
}
