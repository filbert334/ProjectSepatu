using ProjectSepatu.Core.ProductProperties.ProductClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProductClass
{
    public class ProductRepo : RepoBase<Product>
    {
        public ProductRepo(AppDbContext contexts) : base (contexts)
        {

        }
    }
}
