using ProjectSepatu.Core.ProductProperties.UkuranMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.UkuranMasterClass
{
    public class UkuranMasterRepo : RepoBase<UkuranMaster>
    {
        public UkuranMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
