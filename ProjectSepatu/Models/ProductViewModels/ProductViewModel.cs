using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Core.ProductProperties.TransaksiListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.ProductViewModels
{
    public class ProductViewModel
    {
       
    }
    public class ProductCartViewModel
    {
        public TransaksiHeader AddItemHeader { get; set; } = new TransaksiHeader();
        public TransaksiList AddItemList { get; set; } = new TransaksiList();
       
    }
    public class InputProductViewModel
    {
        public ProductMaster Productitem { get; set; }
        public List<Brand> BrandList { get; set; }
        public List<CategoryMaster> CategoryList { get; set; }
        public List<ProductTypeMaster> ProductTypeList { get; set; }
    }
}
