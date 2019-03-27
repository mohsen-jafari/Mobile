using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Enum;
namespace Database.Mobile
{
    public class Network
    {

        public int? Id { get; set; }
        public NetworkEnum?[] Networks { get; set; }

        //public Network(int id , List<NetworkEnum?> networks)
        //{
        //    Id = Id;
        //    Networks = networks;
        //}
        public Network(NetworkEnum?[] networks)
        {
            Networks = networks;
        }
        public Network(int id)
        {
            Id = id;
        }
        public Network()
        {
           
        }
    }
}
