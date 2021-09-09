using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbRibbonsRepository : ICbRibbonsRepository
    {
        private readonly AppDbContext _appDbContext;
        public CbRibbonsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CbRibbons> AllCbRibbons
        {
            get { return _appDbContext.CbRibbons; }
        }
    }
}
