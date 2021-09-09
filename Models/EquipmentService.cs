using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZebraconProdaja.Models
{
    public class EquipmentService
    {
        public int Id { get; set; }
        public CbEquipment CbEquipment { get; set; }
        public CbBrand CbBrand { get; set; }
        public CbModel CbModel { get; set; }
        public string MalfunctionDescription { get; set; }
        public string SpareParts { get; set; }
        public DateTime DateTime { get; set; }
}
}
