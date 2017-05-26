using ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.JenisPembayaranMasterClass
{
    public class JenisPembayaranMasterRepo : RepoBase<JenisPembayaranMaster>
    {
        public JenisPembayaranMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
