using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class CbRibbonsController : Controller
    {
        private readonly ICbRibbonsRepository _cbRibbonsRepository;
        public CbRibbonsController(ICbRibbonsRepository cbRibbonsRepository)
        {
            _cbRibbonsRepository = cbRibbonsRepository;
        }
        public IActionResult List()
        {
            return View(_cbRibbonsRepository.AllCbRibbons);
        }
    }
}
