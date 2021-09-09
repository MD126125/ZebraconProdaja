using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public interface IThermalPrintersRepository
    {
        IEnumerable<ThermalPrinters> AllThermalPrinters { get; }
        ThermalPrinters GetThermalPrintersById(int id);
        IEnumerable<ThermalPrinters> GetThermalPrintersByName(string name);
        IEnumerable<ThermalPrinters> GetThermalPrintersByBrand(string brand);
    }
}
