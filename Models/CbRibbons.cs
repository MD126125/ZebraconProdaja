using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbRibbons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ribbons> Ribbons { get; set; }
    }
}
