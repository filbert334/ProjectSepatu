using ProjectSepatu.Core.ProductProperties.SaranaPengirimanMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.SaranaPengirimanMasterClass
{
    public class SaranaPengirimanMasterRepo : RepoBase<SaranaPengirimanMaster>
    {
        public SaranaPengirimanMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
