using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.UserClass
{
    public class User : IdentityUser
    {
        public long? CustomerId { get; set; }
    }
}
