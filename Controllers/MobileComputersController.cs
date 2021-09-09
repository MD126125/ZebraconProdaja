using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class MobileComputersController : Controller
    {
        private readonly IMobileComputersRepository _mobileComputersRepository;
        public MobileComputersController(IMobileComputersRepository mobileComputersRepository)
        {
            _mobileComputersRepository = mobileComputersRepository;
        }
        public IActionResult List(string name)
        {
            if (name != null)
            {
                return View(_mobileComputersRepository.AllMobileComputers.Where(s => s.CbModel.Name.Contains(name) || name == null).ToList());
            }
            else
            {
                return View(_mobileComputersRepository.AllMobileComputers);
            }
        }
    }
}
