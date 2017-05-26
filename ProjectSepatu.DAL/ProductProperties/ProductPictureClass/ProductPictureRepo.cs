using ProjectSepatu.Core.ProductProperties.ProductPictureClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProductPictureClass
{
    public class ProductPictureRepo : RepoBase<ProductPicture>
    {
        public ProductPictureRepo(AppDbContext contexts) : base (contexts)
        {

        }
    }
}
