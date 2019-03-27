using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Enum;

namespace FormsMobile
{
    public class product
    {
        public string Name { get; set; }

        public BrandEnum? BrandName { get; set; }

        public int Weight { get; set; }

        
    }
}
