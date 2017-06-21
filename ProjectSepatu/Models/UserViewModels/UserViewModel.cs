using ProjectSepatu.Core.ProductProperties.BankMasterClass;
using ProjectSepatu.Core.ProductProperties.CustomerClass;
using ProjectSepatu.Core.ProductProperties.KabupatenMasterClass;
using ProjectSepatu.Core.ProductProperties.KecamatanMasterClass;
using ProjectSepatu.Core.ProductProperties.ProvinsiMasterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.UserViewModels
{
    public class UserViewModel
    {
    }
    public class UserDetailViewModel
    {
        public Customer Customeritem { get; set; }
        public List<KabupatenMaster> KabupatenList { get; set; }
        public List<KecamatanMaster> KecamatanList { get; set; }
        public List<ProvinsiMaster> ProvinsiList { get; set; }
        public List<BankMaster> BankList { get; set; }
    }
}
