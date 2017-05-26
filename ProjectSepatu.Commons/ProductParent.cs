using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Commons
{
    public class ProductParent
    {
        public long Id { get; set; } = 0;
        public string CreatedBy { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Today;
        public string UpdatedBy { get; set; } = "";
        public DateTime UpdatedDate { get; set; } = DateTime.Today;
    }
}
