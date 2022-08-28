using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Benefits
    {
        [Key]
        public int Id { get; set; }
        public int InPatientId { get; set; }
        [ForeignKey("InPatient_Id")]
        public int OutPatientId { get; set; }
        [ForeignKey("OutPatient_Id")]
        public int OthersId { get; set; }
        [ForeignKey("Others_Id")]
        public int SpecialBenefitsId { get; set; }
        [ForeignKey("SpecialBenefits")]
    }
}
