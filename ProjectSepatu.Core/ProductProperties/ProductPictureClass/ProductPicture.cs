using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.ProductPictureClass
{
    public class ProductPicture : ProductParent
    {
        public byte[] Image { get; set; }
        public bool Gambar_Utama { get; set; }

    }
}
