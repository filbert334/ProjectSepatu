using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProductTypeMasterClass
{
    public class ProductTypeMasterRepo : RepoBase<ProductTypeMaster>
    {
        public ProductTypeMasterRepo(AppDbContext contexts) : base(contexts)
        {

        }
    }
}
