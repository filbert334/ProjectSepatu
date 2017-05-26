using ProjectSepatu.Core.ProductProperties.ProductColorClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProductColorClass
{
    public class ProductColorRepo : RepoBase<ProductColor>
    {
        public ProductColorRepo(AppDbContext contexts) : base(contexts)
        {

        }
    }
}
