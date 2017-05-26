using ProjectSepatu.Core.ProductProperties.PerhitunganPengirimanClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL.ProductProperties.PerhitunganPengirimanClass
{
    public class PerhitunganPengirimanRepo : RepoBase<PerhitunganPengiriman>
    {
        public PerhitunganPengirimanRepo(AppDbContext contexts) : base(contexts)
        {
        }
    }
}
