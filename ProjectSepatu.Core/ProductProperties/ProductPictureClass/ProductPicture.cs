using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.ProductPictureClass
{
    public class ProductPicture : ProductParent
    {
        public string Picture { get; set; }
        public bool IsGambarUtama { get; set; }
        public long ProductMasterId { get; set; }
    }
}
