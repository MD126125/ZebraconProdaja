using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class RibbonsController : Controller
    {
        private readonly IRibbonsRepository _ribbonsRepository;
        public RibbonsController(IRibbonsRepository ribbonsRepository)
        {
            _ribbonsRepository = ribbonsRepository;
        }
        public IActionResult List()
        {
            return View(_ribbonsRepository.AllRibbons);
        }
    }
}
