using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class Ribbons
    {
        public int Id { get; set; }
        public CbRibbons CbRibbons { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentNumber { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
