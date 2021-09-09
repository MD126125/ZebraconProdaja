using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public interface IMobileComputersRepository
    {
        IEnumerable<MobileComputers> AllMobileComputers { get; }
        IEnumerable<MobileComputers> GetMobileComputersByName(string name);
        IEnumerable<MobileComputers> GetMobileComputersByBrand(string brand);
    }
}
