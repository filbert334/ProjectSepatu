using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.OperationalViewModel
{
    public class OperationalViewModels
    {
    }
    public class AdminIndexModel
    {
        public List<ProductMaster> ProductMasterList { get; set; }
    }

    public class TabMetodePembayaranModel
    {
        public MetodePembayaranMaster MetodePembayaran { get; set; }
        public List<MetodePembayaranMaster> MetodePembayaranList { get; set; }
    }

    public class TabJenisPembayaranModel
    {
        public JenisPembayaranMaster JenisPembayaranItem { get; set; }
        public List<JenisPembayaranMaster> JenisPembayaranList { get; set; }
        public List<MetodePembayaranMaster> MetodePembayaranList { get; set; }
    }

    public class TabBrandModel
    {
        public Brand BrandItem { get; set; }
        public List<Brand> BrandList { get; set; }
    }

    public class TabCategoryModel
    {
        public CategoryMaster CategoryItem { get; set; }
        public List<CategoryMaster> CategoryList { get; set; }
    }

    public class TabTypeModel
    {
        public ProductTypeMaster Type { get; set; }
        public List<ProductTypeMaster> TypeList { get; set; }
    }
}
