using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class LabelsController : Controller
    {
        private readonly ILabelsRepository _labelsRepository;
        public LabelsController(ILabelsRepository cbBrandRepository)
        {
            _labelsRepository = cbBrandRepository;
        }
        public IActionResult List()
        {
            return View(_labelsRepository.AllLabels);
        }
    }
}
