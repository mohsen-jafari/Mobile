using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database.Enum;
using Database.View;
namespace Database.Mobile.Query
{
    public class SqlQueryNetworkMobile
    {
        public void InsertId(Mobile MobileDB, Network NetworkDB , int i)
        {
            var InsertMobileQuery = "insert into dbo.[NetworkMobile] (Mobile_Id , Network_Id) values ( @val1, @val2 );";

            var connect = Connection.SqlConnectionObject;
            SqlQueryBrand SQbrand = new SqlQueryBrand();

            connect.Open();
            SqlQueryNetwork SQImage = new SqlQueryNetwork();
            var Network = SQImage.GetNetwork(NetworkDB, i);
            SqlQueryMobile SQMobile = new SqlQueryMobile();
            var Mobile  = SQMobile.GetMobile(MobileDB);

            SqlCommand command = new SqlCommand(InsertMobileQuery, connect);
            command.Parameters.AddWithValue("@val1", Mobile.Id);
            command.Parameters.AddWithValue("@val2", Network.Id);

            var value = command.ExecuteNonQuery();
            connect.Close();

        }
        public Network GetMobileNetwork(Mobile MobileDB)
        {
            //var Name = MobileDB.Brand.;
            var connect = Connection.SqlConnectionObject;
            connect.Open();

            string Query = String.Format("SELECT dbo.Mobile.Id as Id , dbo.NetworkMobile.Network_Id as NetworkId, dbo.Network.NetworkType as NetworkType"+
                " FROM dbo.Mobile left JOIN dbo.NetworkMobile ON dbo.Mobile.Id = dbo.NetworkMobile.Mobile_Id left JOIN dbo.Network ON dbo.NetworkMobile.Network_Id = dbo.Network.Id "+
                " where dbo.Mobile.Id ={0} ;", MobileDB.Id);
            
            SqlCommand command = new SqlCommand(Query, connect);
            var rd = command.ExecuteReader();
            //List<Network> Networklist = new List<Network>();
            Network NetworkMod = new Network();
            NetworkMod.Networks = new NetworkEnum?[3];
            while (rd.Read())
            {
                int s = 0;
                if (int.TryParse(rd["NetworkId"].ToString(), out s ))
                {
                    NetworkMod.Id = int.Parse(rd["NetworkId"].ToString());
                }
              

                if (rd["NetworkType"].ToString() != null)
                {
                    string X = rd["NetworkType"].ToString();

                    if (X == "G2")
                    { NetworkMod.Networks[0] = GetNetworkEnum(rd["NetworkType"].ToString()); }
                    else if (X == "G3")
                    { NetworkMod.Networks[1] = GetNetworkEnum(rd["NetworkType"].ToString()); }
                    else if (X == "G4")
                    { NetworkMod.Networks[2] = GetNetworkEnum(rd["NetworkType"].ToString()); }

                }
                   

                //Networklist.Add(NetworkMod);
                //MobileQ.Network.Networks[0] = GetNetworkEnum( rd["dbo.Network.NetworkType"].ToString());
            }
            connect.Close();
            return NetworkMod;
        }
        public Network GetMobileNetworkView(MobileView MobileVI)
        {
            //var Name = MobileDB.Brand.;
            var connect = Connection.SqlConnectionObject;
            connect.Open();


            string Query = String.Format("SELECT dbo.Mobile.Id as Id , dbo.NetworkMobile.Network_Id as NetworkId, dbo.Network.NetworkType as NetworkType" +
                " FROM dbo.Mobile left JOIN dbo.NetworkMobile ON dbo.Mobile.Id = dbo.NetworkMobile.Mobile_Id left JOIN dbo.Network ON dbo.NetworkMobile.Network_Id = dbo.Network.Id " +
                " where dbo.Mobile.Id ={0} ;", MobileVI.Id);


            //string Query = String.Format(" SELECT dbo.MobileReportView.MobileId as Id , dbo.NetworkMobile.Network_Id as NewtorkId, dbo.Network.NetworkType as NetworkType " +
            //               " FROM dbo.MobileReportView Left JOIN dbo.NetworkMobile ON dbo.MobileReportView.MobileId = dbo.NetworkMobile.Id Left JOIN dbo.Network ON dbo.NetworkMobile.Network_Id = dbo.Network.Id " +
            //                "where dbo.MobileReportView.MobileId = {0}", MobileVI.Id );

            SqlCommand command = new SqlCommand(Query, connect);
            var rd = command.ExecuteReader();
            //List<Network> Networklist = new List<Network>();
            Network NetworkMod = new Network();
            NetworkMod.Networks = new NetworkEnum?[3];
            while (rd.Read())
            {


                int s = 0;
                if (int.TryParse(rd["NetworkId"].ToString(), out s))
                {
                    NetworkMod.Id = int.Parse(rd["NetworkId"].ToString());
                }

                if (rd["NetworkType"].ToString() != null)
                {
                    string X = rd["NetworkType"].ToString();

                    if (X == "G2")
                    { NetworkMod.Networks[0] = GetNetworkEnum(rd["NetworkType"].ToString()); }
                    else if (X == "G3")
                    { NetworkMod.Networks[1] = GetNetworkEnum(rd["NetworkType"].ToString()); }
                    else if (X == "G4")
                    { NetworkMod.Networks[2] = GetNetworkEnum(rd["NetworkType"].ToString()); }

                }
                
            }

            connect.Close();
            return NetworkMod;
        }

        
        public void DeleteNetwork(Mobile MobileDB)
        {
            string UpdateQuery = "DELETE FROM dbo.NetworkMobile WHERE Mobile_Id = @val1;";

            //SqlQueryBrand SQbrand = new SqlQueryBrand();
            //MobileDB.BrandId = SQbrand.GetBrandId(MobileDB);

            var connect = Connection.SqlConnectionObject;
            connect.Open();
            SqlCommand command = new SqlCommand(UpdateQuery, connect);
            command.Parameters.AddWithValue("@val1", MobileDB.Id);

            var value = command.ExecuteNonQuery();
            connect.Close();
        }
        public NetworkEnum? GetNetworkEnum(string Network)
        {
            NetworkEnum? NetworkType = null ;
            if (Network == "G2")
            {
                NetworkType = NetworkEnum.G2;
            }
            else if (Network == "G3")
            {
                NetworkType = NetworkEnum.G3;
            }
            else if (Network == "G4")
            {
                NetworkType = NetworkEnum.G4;
            }
            return NetworkType;
        }
    }
}
