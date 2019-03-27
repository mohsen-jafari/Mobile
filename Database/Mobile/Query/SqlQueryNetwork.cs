using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database.Enum;
namespace Database.Mobile.Query
{
    class SqlQueryNetwork
    {

        public Network GetNetwork(Network NetworkDB, int i)
        {
            var connect = Connection.SqlConnectionObject;
            connect.Open();

            Network NetworkMod = new Network();
            //NetworkMod.Networks = new NetworkEnum?[3];


            string Query = "select top 1 Id , NetworkType from dbo.Network where [NetworkType]= @val1";
            SqlCommand command = new SqlCommand(Query, connect);
            command.Parameters.AddWithValue("@val1", NetworkDB.Networks[i].ToString());
            var rd = command.ExecuteReader();
            //int Id = 0;
            //List<Network> Network = new List<Network>();
            while (rd.Read())
            {
                NetworkMod.Id = int.Parse(rd["Id"].ToString());
            }


            connect.Close();
            return NetworkMod;
        }
        public NetworkEnum? GetNetworkEnum(string Network)
        {
            NetworkEnum? NetworkType = null;
            if (Network == "2G")
            {
                NetworkType = NetworkEnum.G2;
            }
            else if (Network == "3G")
            {
                NetworkType = NetworkEnum.G3;
            }
            else if (Network == "4G")
            {
                NetworkType = NetworkEnum.G4;
            }
            return NetworkType;
        }
    }
}
