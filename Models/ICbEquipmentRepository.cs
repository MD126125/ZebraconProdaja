using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
     public interface ICbEquipmentRepository
    {
        IEnumerable<CbEquipment> AllCbEquipment { get; }
    }
}
