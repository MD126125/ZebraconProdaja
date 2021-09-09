using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class ThermalPrintersRepository : IThermalPrintersRepository
    {
        private readonly AppDbContext _appDbContext;
        public ThermalPrintersRepository(AppDbContext appDbContext)
        { 
            _appDbContext = appDbContext;
        }

        public IEnumerable<ThermalPrinters> AllThermalPrinters
        {
            get { return _appDbContext.ThermalPrinters.Include(c =>c.CbModel).Include(c =>c.CbBrand); }
        }
        public ThermalPrinters GetThermalPrintersById(int thermalPrintersId)
        {
            var ThermalPrinter = _appDbContext.ThermalPrinters.FirstOrDefault(c => c.Id == thermalPrintersId);
            return ThermalPrinter;
        }

        public IEnumerable<ThermalPrinters> GetThermalPrintersByName(string name)
        {
            return _appDbContext.ThermalPrinters.Where(c => c.CbModel.Name == name);
        }
        public IEnumerable<ThermalPrinters> GetThermalPrintersByBrand(string brand)
        {
            return _appDbContext.ThermalPrinters.Where(c => c.CbBrand.Name == brand);
        }
    }
}
