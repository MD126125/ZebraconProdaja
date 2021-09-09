using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ThermalPrinters> ThermalPrinters { get; set; }
        public DbSet<MobileComputers>  MobileComputers{ get; set; }
        public DbSet<BarcodeScanners>  BarcodeScanners{ get; set; }
        public DbSet<CbEquipment> CbEquipment { get; set; }
        public DbSet<CbBrand> CbBrand { get; set; }
        public DbSet<CbModel> CbModel { get; set; }
        public DbSet<EquipmentService> EquipmentService { get; set; }
        public DbSet<Labels> Labels { get; set; }
        public DbSet<Ribbons> Ribbons { get; set; }
        public DbSet<CbLabels> CbLabels { get; set; }
        public DbSet<CbRibbons> CbRibbons { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
