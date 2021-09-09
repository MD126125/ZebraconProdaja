using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class EquipmentServiceController : Controller
    {
        private readonly IEquipmentServiceRepository _equipmentServiceRepository;
        public EquipmentServiceController(IEquipmentServiceRepository equipmentServiceRepository)
        {
            _equipmentServiceRepository = equipmentServiceRepository;
        }
        public IActionResult List()
        {
            return View(_equipmentServiceRepository.AllEquipmentService);
        }
        public ViewResult AddEquipmentService()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddEquipmentService(EquipmentService equipmentService)
        {
            _equipmentServiceRepository.GetAllEquipmentService(equipmentService);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }   
        
}
