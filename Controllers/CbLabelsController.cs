using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class CbLabelsController : Controller
    {
        private readonly ICbLabelsRepository _cbLabelsRepository;
        public CbLabelsController(ICbLabelsRepository cbLabelsRepository)
        {
            _cbLabelsRepository = cbLabelsRepository;
        }
        public IActionResult List()
        {
            return View(_cbLabelsRepository.AllCbLabels);
        }
    }
}
