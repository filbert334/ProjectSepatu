using ProjectSepatu.Core.ProductProperties.RefundClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.RefundClass
{
    public class RefundRepo : RepoBase<Refund>
    {
        public RefundRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
