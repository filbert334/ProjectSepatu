using ProjectSepatu.Core.ProductProperties.CabangMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.CabangMasterClass
{
    public class CabangMasterRepo : RepoBase<CabangMaster>
    {
        public CabangMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
