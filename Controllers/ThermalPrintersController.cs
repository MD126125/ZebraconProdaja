using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class ThermalPrintersController : Controller
    {
        private readonly ICbBrandRepository _cbBrandRepository;
        private readonly IThermalPrintersRepository _thermalPrinterRepository;
        public ThermalPrintersController(IThermalPrintersRepository thermalPrintersRepository, ICbBrandRepository cbBrandRepository)
        {
            _thermalPrinterRepository = thermalPrintersRepository;
            _cbBrandRepository = cbBrandRepository;
        }
        /*
        public IActionResult List()
        {
            return View(_thermalPrinterRepository.AllThermalPrinters);
        }
        */
        public IActionResult Details(int id)
        {
            var thermalprinter = _thermalPrinterRepository.GetThermalPrintersById(id);
            if (thermalprinter == null)
            {
                return NotFound();
            }
            return View(thermalprinter);
        }
        
        public IActionResult List(string name)
        {
            if (name != null )
                {
                return View(_thermalPrinterRepository.AllThermalPrinters.Where(s => s.CbModel.Name.Contains(name) || name == null).ToList());
                }          
            else          
                {
                    return View(_thermalPrinterRepository.AllThermalPrinters);
                }
        }
        public IActionResult List1(string brand)
        {
            if (brand != null)
            {
                return View(_thermalPrinterRepository.AllThermalPrinters.Where(s => s.CbBrand.Name.Contains(brand) || brand == null).ToList());
            }
            else
            {
                return View(_thermalPrinterRepository.AllThermalPrinters);
            }
        }

    }
}
