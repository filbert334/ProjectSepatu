using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.ManageProductViewModels
{
    public class ManageProductViewModel
    {
    }
    public class TabProductListViewModel
    {
        public List<ProductMaster> ProductMasterList { get; set; }
        public List<Brand> BrandList { get; set; }
        public List<CategoryMaster> CategoryList { get; set; }
        public List<ProductTypeMaster> ProductTypeList { get; set; }

    }
}
