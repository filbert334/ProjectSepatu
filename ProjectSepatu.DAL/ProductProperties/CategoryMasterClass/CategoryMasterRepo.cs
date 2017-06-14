using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.CategoryMasterClass
{
    public class CategoryMasterRepo : RepoBase<CategoryMaster>
    {
        public CategoryMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
