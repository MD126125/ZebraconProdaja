using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;

namespace ZebraconProdaja.Controllers
{
    public class CbModelMenu : ViewComponent
    {
        private readonly ICbModelRepository _cbModelRepository;

        public CbModelMenu(ICbModelRepository cbModelRepository)
        {
            _cbModelRepository = cbModelRepository;
        }
        public IViewComponentResult Invoke()
        {
            var cbBrand = _cbModelRepository.AllCbModel.OrderBy(c => c.Name);
            return View(cbBrand);
        }
        
    }
}
