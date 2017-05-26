using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.KabupatenMasterClass
{
    public class KabupatenMaster : ProductParent
    {
        public string Nama_Kabupaten { get; set; }

        public long ProvinsiMasterId { get; set; }
    }
}
