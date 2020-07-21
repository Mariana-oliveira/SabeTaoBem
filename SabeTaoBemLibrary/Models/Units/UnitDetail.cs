using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Units
{
    public class UnitDetail
    {
        public byte IdUnit { get; set; }
        public string UnitName { get; set; }
        public byte UnitCategoryId { get; set; }
        public string Category { get; set; }
        public byte UnitSystemId { get; set; }
        public string System { get; set; }
    }
}
