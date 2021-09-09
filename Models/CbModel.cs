using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CbBrand CbBrand { get; set; }
        public List<ThermalPrinters> TermalPrinters { get; set; }
        public List<MobileComputers> MobileComputers { get; set; }
        public List<BarcodeScanners> BarcodeScanners { get; set; }
    }
}
