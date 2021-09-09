using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class BarcodeScannersRepository : IBarcodeScannersRepository
    {
        private readonly AppDbContext _appDbContext;
        public BarcodeScannersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<BarcodeScanners> AllBarcodeScanners
        {
            get { return _appDbContext.BarcodeScanners.Include(c => c.CbModel).Include(c => c.CbBrand); }
        }
    }
}
