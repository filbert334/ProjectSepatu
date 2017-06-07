using ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass
{
    public class MetodePembayaranMasterRepo : RepoBase<MetodePembayaranMaster>
    {
        public MetodePembayaranMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
