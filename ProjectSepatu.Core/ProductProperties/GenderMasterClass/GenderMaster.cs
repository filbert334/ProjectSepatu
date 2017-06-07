using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.GenderMasterClass
{
    public class GenderMaster : ProductParent
    {
        public string Gender { get; set; }
        public bool IsHidden { get; set; }
    }
}
