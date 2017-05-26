using ProjectSepatu.Core.ProductProperties.KabupatenMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.KabupatenMasterClass
{
    public class KabupatenMasterRepo : RepoBase<KabupatenMaster>
    {
        public KabupatenMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
