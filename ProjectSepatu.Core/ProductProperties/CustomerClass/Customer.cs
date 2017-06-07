using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.CustomerClass
{
    public class Customer : ProductParent
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsHidden { get; set; }
    }
}
