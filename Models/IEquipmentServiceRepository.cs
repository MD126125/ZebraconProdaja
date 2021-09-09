using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public interface IEquipmentServiceRepository
    {
        IEnumerable<EquipmentService> AllEquipmentService { get; }
        EquipmentService GetAllEquipmentService(string equipmentService);
        void GetAllEquipmentService(EquipmentService equipmentService);
    }
}
