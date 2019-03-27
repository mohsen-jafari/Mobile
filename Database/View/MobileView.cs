using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Enum;
using Database.Mobile;
namespace Database.View
{
   public class MobileView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandEnum? BrandN { get; set; }
        public DateTime? ProductionDate { get; set; }
        public int Weight { get; set; }
        public bool Otg { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public NetworkEnum?[] Networks { get; set; }
    }
}
