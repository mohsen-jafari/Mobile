using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Mobile
{
   public class Mobile
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int BrandId { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Weight { get; set; }
        public bool Otg { get; set; }
        public int UserId { get; set; }

        //public Brand BrandN { get; set; }
        //public Network Network { get; set; }
        //public Image ImageC { get; set; }

    }
}
