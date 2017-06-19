using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.BankMasterClass
{
    public class BankMaster : ProductParent
    {
        public string Nama_Bank { get; set; }
        public bool IsHidden { get; set; }
    }
}
