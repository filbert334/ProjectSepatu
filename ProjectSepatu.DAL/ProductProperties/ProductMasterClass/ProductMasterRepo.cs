using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProductMasterClass
{
    public class ProductMasterRepo : RepoBase<ProductMaster>
    {
        public ProductMasterRepo(AppDbContext contexts) : base (contexts)
        {

        }
    }
}
