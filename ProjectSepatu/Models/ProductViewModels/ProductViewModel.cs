using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Core.ProductProperties.TransaksiListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.ProductViewModels
{
    public class ProductViewModel
    {
    }
    public class ProductCartViewModel
    {
        public TransaksiHeader AddItemHeader { get; set; } = new TransaksiHeader();
        public TransaksiList AddItemList { get; set; } = new TransaksiList();
    }
}
