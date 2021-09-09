using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbLabels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Labels> Labels{ get; set; }
    }
}
