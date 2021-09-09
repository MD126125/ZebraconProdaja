using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal TotalAmount { get; set; }
        public CbBrand CbBrand { get; set; }
        public CbModel CbModel { get; set; }
    }

}
