using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.ProductColorClass
{
    public class ProductColor : ProductParent
    {
        public long ProductMasterId { get; set; }
        public long ProductColorMasterId { get; set; }
    }
}
