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

        public int InPatient_Id { get; set; }
        [ForeignKey("InPatient_Id")]

        public InPatient inPatient { get; set; }

        public int OutPatient_Id { get; set; }
        [ForeignKey("OutPatient_Id")]

        public OutPatient outPatient { get; set; }

        public int Others_Id { get; set; }
        [ForeignKey("Others_Id")]

        public Others others { get; set; }

        public int SpecialBenefits_Id { get; set; }
        [ForeignKey("SpecialBenefits_Id")]

        public SpecialBenefits specialBenefits { get; set; }


    }
}
