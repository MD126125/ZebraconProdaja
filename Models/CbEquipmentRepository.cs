using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbEquipmentRepository : ICbEquipmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public CbEquipmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CbEquipment> AllCbEquipment
        {
            get { return _appDbContext.CbEquipment; }
        }
    }
}
