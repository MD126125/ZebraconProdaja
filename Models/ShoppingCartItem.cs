using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public CbBrand? CbBrand { get; set; }
        public CbModel? CbModel { get; set; }
        public ThermalPrinters? ThermalPrinters { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
