using ProjectSepatu.Core.ProductProperties.TransaksiListClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.TransaksiListClass
{
    public class TransaksiListRepo : RepoBase<TransaksiList>
    {
        public TransaksiListRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
