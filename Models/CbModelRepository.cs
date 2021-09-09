using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbModelRepository : ICbModelRepository
    {
        private readonly AppDbContext _appDbContext;
        public CbModelRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CbModel> AllCbModel
        {
            get { return _appDbContext.CbModel.Include(c => c.CbBrand); }
        }
    }
}
