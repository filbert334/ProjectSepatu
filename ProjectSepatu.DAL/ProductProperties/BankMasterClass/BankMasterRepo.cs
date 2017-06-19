using ProjectSepatu.Core.ProductProperties.BankMasterClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.BankMasterClass
{
    public class BankMasterRepo : RepoBase<BankMaster>
    {
        public BankMasterRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
