using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class MobileComputers
    {
        public int Id { get; set; }
        public CbBrand CbBrand { get; set; }
        public CbModel CbModel { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public int CurrentNumber { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
