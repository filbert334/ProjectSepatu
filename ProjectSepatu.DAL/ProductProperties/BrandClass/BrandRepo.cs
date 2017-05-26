using ProjectSepatu.Core.ProductProperties.BrandClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.BrandClass
{
    public class BrandRepo : RepoBase<Brand>
    {
        public BrandRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
