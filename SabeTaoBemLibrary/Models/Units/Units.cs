using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Units
{
    public class Units
    {
        public byte IdUnit { get; set; }
        public string UnitName { get; set; }
        public byte UnitCategoryId { get; set; }
        public byte UnitSystemId { get; set; }
    }
}
