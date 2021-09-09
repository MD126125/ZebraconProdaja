using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class CbEquipmentController : Controller
    {
        private readonly ICbEquipmentRepository _cbEquipmentRepository;
        public CbEquipmentController(ICbEquipmentRepository cbEquipmentRepository)
        {
            _cbEquipmentRepository = cbEquipmentRepository;
        }
        public IActionResult List()
        {
            return View(_cbEquipmentRepository.AllCbEquipment);
        }
    }
}
