using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbLabelsRepository : ICbLabelsRepository
    {
        private readonly AppDbContext _appDbContext;
        public CbLabelsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CbLabels> AllCbLabels
        {
            get { return _appDbContext.CbLabels; }
        }
    }
}
