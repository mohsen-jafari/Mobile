using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Enum;
namespace Database.Mobile
{
    public class Brand
    {
        public int Id { get; set; }
        public BrandEnum? Name { get; set; }

        public Brand(int id ,BrandEnum? name)
        {
            Id = Id;
            Name = name;
        }
        public Brand( BrandEnum? name)
        {
            
            Name = name;
        }
        public Brand()
        {
            
        }
    }
}
