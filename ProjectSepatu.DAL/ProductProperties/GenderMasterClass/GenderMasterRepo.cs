using ProjectSepatu.Core.ProductProperties.GenderMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.GenderMasterClass
{
    public class GenderMasterRepo : RepoBase<GenderMaster>
    {
        public GenderMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
