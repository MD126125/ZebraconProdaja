using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class LabelsRepository : ILabelsRepository
    {
        private readonly AppDbContext _appDbContext;
        public LabelsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Labels> AllLabels
        {
            get { return _appDbContext.Labels.Include(c => c.CbLabels); }
        }
    }
}
