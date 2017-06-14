using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.CategoryMasterClass
{
    public class CategoryMaster : ProductParent
    {
        public string Gender { get; set; }
        public bool IsHidden { get; set; }
    }
}
