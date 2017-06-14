using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.GenderMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
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
        public List<GenderMaster> GenderList { get; set; } = new List<GenderMaster>();
        public List<Brand> BrandList { get; set; } = new List<Brand>();
    }
    public class ListViewModel
    {
        public List<ProductMaster> listProducts { get; set; } = new List<ProductMaster>();
        public int TypeId { get; set; }
    }
}
