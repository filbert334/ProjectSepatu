using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.TransaksiHeaderClass
{
    public class TransaksiHeaderRepo : RepoBase<TransaksiHeader>
    {
        public TransaksiHeaderRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
