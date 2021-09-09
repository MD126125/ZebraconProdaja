using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class CbBrandController : Controller
    {
        private readonly ICbBrandRepository _cbBrandRepository;
        public CbBrandController(ICbBrandRepository cbBrandRepository)
        {
            _cbBrandRepository = cbBrandRepository;
        }
        public IActionResult List()
        {
            return View(_cbBrandRepository.AllCbBrand);
        }
    }
}
