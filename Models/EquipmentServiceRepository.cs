using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class EquipmentServiceRepository : IEquipmentServiceRepository
    {
        private readonly AppDbContext _appDbContext;
        public EquipmentServiceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<EquipmentService> AllEquipmentService
        {
            get { return _appDbContext.EquipmentService.Include(c => c.CbEquipment).Include(c => c.CbBrand).Include(c => c.CbModel); }
        }
        public int AddEquipmentService(EquipmentService model)
        {
            var newEquipmentService = new EquipmentService()
            {
                CbEquipment = model.CbEquipment,
                CbBrand = model.CbBrand,
                CbModel = model.CbModel,
                MalfunctionDescription = model.MalfunctionDescription,
                SpareParts = model.SpareParts,
                DateTime = DateTime.UtcNow
            };
            _appDbContext.EquipmentService.Add(newEquipmentService);
            _appDbContext.SaveChanges();
            return newEquipmentService.Id;
        }

        public EquipmentService GetAllEquipmentService(string equipmentService)
        {
            throw new NotImplementedException();
        }

        public void GetAllEquipmentService()
        {
            throw new NotImplementedException();
        }

        public void GetAllEquipmentService(EquipmentService equipmentService)
        {
            throw new NotImplementedException();
        }
    }
}
