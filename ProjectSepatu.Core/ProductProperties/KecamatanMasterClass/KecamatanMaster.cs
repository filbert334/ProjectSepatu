using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.KecamatanMasterClass
{
    public class KecamatanMaster : ProductParent
    {
        public string Nama_Kecamatan { get; set; }

        public long KabupatenMasterId { get; set; }
    }
}
