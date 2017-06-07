using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.ProductDetailsClass
{
    public class ProductDetails : ProductParent
    {
        public long Jumlah_Stock { get; set; }


        public long ProductMasterId { get; set; }
        public long ColorMasterId { get; set; }
        public long UkuranMasterId { get; set; }
    }
}
