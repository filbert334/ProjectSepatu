using ProjectSepatu.Core.ProductProperties.CustomerClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.CustomerClass
{
    public class CustomerRepo : RepoBase<Customer>
    {
        public CustomerRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
