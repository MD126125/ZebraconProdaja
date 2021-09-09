using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class CbEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CbBrand> CbBrand { get; set; }
        public List<EquipmentService> EquipmentService { get; set; }
    }
}
