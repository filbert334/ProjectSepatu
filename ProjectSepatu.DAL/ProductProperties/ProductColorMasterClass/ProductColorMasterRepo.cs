using ProjectSepatu.Core.ProductProperties.ProductColorMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProductColorMasterClass
{
    public class ProductColorMasterRepo : RepoBase<ProductColorMaster>
    {
        public ProductColorMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
