using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database.Enum;

namespace Database.Mobile.Query
{
    public class SqlQueryBrand
    {
        public int GetBrandId(Brand brandDB)
        {
            //var Name = MobileDB.Brand.;
            var connect = Connection.SqlConnectionObject;
            connect.Open();
            string Query = String.Format("select top 1 Id from dbo.Brand where [Brand]='{0}'", brandDB.Name);
            SqlCommand command = new SqlCommand(Query, connect);
            var rd = command.ExecuteReader();
            Mobile MobileQ = new Mobile();
            while (rd.Read())
            {
                MobileQ.BrandId = int.Parse(rd["Id"].ToString());
            }
            connect.Close();
            return MobileQ.BrandId;
        }

        //public Brande GetBrandName(MobileView MobileId )
        //{
        //    var connect = Connection.SqlConnectionObject;
        //    connect.Open();
        //    string Query = String.Format("select top 1 Id, Brand from dbo.Brand where [Id]='{0}'", MobileId.BrandId);
        //    SqlCommand command = new SqlCommand(Query, connect);
        //    var rd = command.ExecuteReader();

        //    //Mobile MobileQ = new Mobile();
        //    while (rd.Read())
        //    {
        //        var id = int.Parse(rd["Id"].ToString());
        //        var brand = GetBrandEnum(rd["Brand"].ToString());
        //        MobileId.BrandN = new Brand(id,brand);
                
        //    }
        //    connect.Close();
        //    return MobileId.BrandN;
        //}
        public Brand GetBrandName(int BrandId)
        {
            var connect = Connection.SqlConnectionObject;
            connect.Open();
            string Query = String.Format("select top 1 Id, Brand from dbo.Brand where [Id]='{0}'", BrandId);
            SqlCommand command = new SqlCommand(Query, connect);
            var rd = command.ExecuteReader();
            Brand BrandN = new Brand();
            //Mobile MobileQ = new Mobile();
            while (rd.Read())
            {
                BrandN.Id = int.Parse(rd["Id"].ToString());
                BrandN.Name = GetBrandEnum(rd["Brand"].ToString());
                //Brand BrandN = new Brand(id, brand);

            }
            connect.Close();
            return BrandN;
        }
        public BrandEnum? GetBrandEnum(string brand)
        {
            BrandEnum? BrandName = null;
            if (brand == "apple")
            {
                BrandName = BrandEnum.apple;
            }
            else if (brand == "Xiaomi")
            {
                BrandName = BrandEnum.Xiaomi;
            }
            else if (brand == "Samsung")
            {
                BrandName = BrandEnum.Samsung;
            }
            else if (brand == "LG")
            {
                BrandName = BrandEnum.LG;
            }
            return BrandName;
        }
    }
}
