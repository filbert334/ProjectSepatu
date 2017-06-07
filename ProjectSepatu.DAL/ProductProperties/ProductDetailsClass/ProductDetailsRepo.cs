using ProjectSepatu.Core.ProductProperties.ProductDetailsClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProductDetailsClass
{
    public class ProductDetailsRepo : RepoBase<ProductDetails>
    {
        public ProductDetailsRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
