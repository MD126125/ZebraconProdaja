using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class CbModelController : Controller
    {
        private readonly ICbModelRepository _cbModelRepository;
        public CbModelController(ICbModelRepository cbModelRepository)
        {
            _cbModelRepository = cbModelRepository;
        }
        public IActionResult List()
        {
            return View(_cbModelRepository.AllCbModel);
        }
    }
}
