using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.HomeViewModels
{
    public class HomePageViewModel
    {
        public List<ProductMaster> listProduct { get; set; } = new List<ProductMaster>();
        
    }
}
