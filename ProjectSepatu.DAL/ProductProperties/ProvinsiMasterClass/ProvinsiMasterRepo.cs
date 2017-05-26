using ProjectSepatu.Core.ProductProperties.ProvinsiMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.ProvinsiMasterClass
{
    public class ProvinsiMasterRepo : RepoBase<ProvinsiMaster>
    {
        public ProvinsiMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
