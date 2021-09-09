using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class BarcodeScannersController : Controller
    {
        private readonly IBarcodeScannersRepository _barcodeScannersRepository;
        public BarcodeScannersController(IBarcodeScannersRepository barcodeScannersRepository)
        {
            _barcodeScannersRepository = barcodeScannersRepository;
        }
        public IActionResult List()
        {
            return View(_barcodeScannersRepository.AllBarcodeScanners);
        }
    }
}
