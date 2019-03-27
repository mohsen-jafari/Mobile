using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Enum;


namespace FormsMobile
{
    
    public class MobileVM : product
    {
        //public string Name { get; set; }
        //public Brand? BrandName { get; set; }
        public DateTime ProductionDate { get; set; }

        //public int Weight { get; set; }

        public bool Otg { get; set; }
        public NetworkEnum?[] Networks { get; set; }
        public ImageMobile Image { get; set; }
        public int Number { get; set; }

        //public Mobile()
        //{

        //}
        //public Network? g2, g3, g4;
        //public Mobile(string name, Brand brandName, DateTime productionDate, int Weinght, bool otg, Network?[] networks)
        //{

        //    Name = name;
        //    BrandName = brandName;
        //    ProductionDate = productionDate;
        //    Weight = Weinght;
        //    Otg = otg;
        //    Networks = networks;
        //}
    }

}
