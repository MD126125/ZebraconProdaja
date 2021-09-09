using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CbEquipment CbEquipment { get; set; }
        public List<ThermalPrinters> TermalPrinters { get; set; }
        public List<MobileComputers> MobileComputers { get; set; }
        public List<BarcodeScanners> BarcodeScanners { get; set; }
    }
}
