using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class MobileComputersRepository : IMobileComputersRepository
    {
        private readonly AppDbContext _appDbContext;
        public MobileComputersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<MobileComputers> AllMobileComputers
        {
            get { return _appDbContext.MobileComputers.Include(c => c.CbModel).Include(c => c.CbBrand); }
        }
        public IEnumerable<MobileComputers> GetMobileComputersByName(string name)
        {
            return _appDbContext.MobileComputers.Where(c => c.CbModel.Name == name);
        }
        public IEnumerable<MobileComputers> GetMobileComputersByBrand(string brand)
        {
            return _appDbContext.MobileComputers.Where(c => c.CbBrand.Name == brand);
        }
    }
}
