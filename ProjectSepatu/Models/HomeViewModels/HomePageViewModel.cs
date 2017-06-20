using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductPictureClass;
using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.HomeViewModels
{
    public class HomePageViewModel
    {
        public List<ProductMaster> listProduct { get; set; } = new List<ProductMaster>();
        public List<ProductMaster> listLatestProduct { get; set; } = new List<ProductMaster>();
        public List<ProductTypeMaster> ProductTypeList { get; set; } = new List<ProductTypeMaster>();
        public List<CategoryMaster> CategoryList{ get; set; } = new List<CategoryMaster>();
        public List<Brand> BrandList { get; set; } = new List<Brand>();
    }
    public class ListViewModel
    {
        public List<ProductMaster> listProducts { get; set; } = new List<ProductMaster>();
        public int TypeId { get; set; }
        public List<ProductTypeMaster> ProductTypeList { get; set; } = new List<ProductTypeMaster>();
        public List<Brand> BrandList { get; set; } = new List<Brand>();
        public List<CategoryMaster> CategoryList { get; set; } = new List<CategoryMaster>();
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }

    public class ProductDetailsViewModel
    {
        public ProductMaster ProductDetails { get; set; }
        public List<ProductMaster> RelatedProducts { get; set; } = new List<ProductMaster>();
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}
