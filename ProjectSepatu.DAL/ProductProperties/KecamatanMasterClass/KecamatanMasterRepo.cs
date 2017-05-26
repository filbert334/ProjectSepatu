using ProjectSepatu.Core.ProductProperties.KecamatanMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.KecamatanMasterClass
{
    public class KecamatanMasterRepo : RepoBase<KecamatanMaster>
    {
        public KecamatanMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
