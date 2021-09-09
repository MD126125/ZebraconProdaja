using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbBrandRepository : ICbBrandRepository
    {
        private readonly AppDbContext _appDbContext;
        public CbBrandRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CbBrand> AllCbBrand
        {
            get { return _appDbContext.CbBrand.Include(c => c.CbEquipment); }
        }
    }
}
