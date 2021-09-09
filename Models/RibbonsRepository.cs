﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class RibbonsRepository : IRibbonsRepository
    {
        private readonly AppDbContext _appDbContext;
        public RibbonsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Ribbons> AllRibbons
        {
            get { return _appDbContext.Ribbons.Include(c => c.CbRibbons); ; }
        }
    }
}
