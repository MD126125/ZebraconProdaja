using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.ViewModels
{
    public class ThermalPrinterListViewModel
    {
        public IEnumerable<ThermalPrinters> ThermalPrinterss { get; set; }
        public IEnumerable<CbBrand> CbBrands { get; set; }
        public IEnumerable<CbModel> CbModel { get; set; }
    }
}
