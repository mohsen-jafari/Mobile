using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database.Mobile;
using Database.Enum;
using Database.User;

namespace Database.Mobile.Query
{
    public class SqlQueryMobile
    {
        public void InsertMobile(Mobile MobileDB, int UserId )
        {


            var InsertMobileQuery = "insert into dbo.Mobile ([Name],BrandId,ProductionDate,[Weight],Otg,UserId)values " +
                                    "(@val1 , @val2 , @val3 , @val4 , @val5 , @val6 );";

            //var connect = connecting.SqlConnectionObject;

            //MobileDB.BrandId = brandsqlquery.GetBrand(Name).Id;
            MobileDB.UserId = UserId;

            var connect = Connection.SqlConnectionObject;
            //SqlQueryBrand SQbrand = new SqlQueryBrand();
            //MobileDB.BrandId = SQbrand.GetBrandId(MobileDB);
            //SqlQueryImage SQImage = new SqlQueryImage();
            //MobileDB.Id = SQbrand.GetImageId(MobileDB);
            connect.Open();

            SqlCommand command = new SqlCommand(InsertMobileQuery, connect);
            command.Parameters.AddWithValue("@val1", MobileDB.Name);
            command.Parameters.AddWithValue("@val2", MobileDB.BrandId);
            command.Parameters.AddWithValue("@val3", MobileDB.ProductionDate);
            command.Parameters.AddWithValue("@val4", MobileDB.Weight);
            command.Parameters.AddWithValue("@val5", MobileDB.Otg);
            command.Parameters.AddWithValue("@val6", MobileDB.UserId);

            var value = command.ExecuteNonQuery();
            connect.Close();

        }

        public void UpdateMobile(Mobile MobileDB , int UserId)
        {
            
            string UpdateQuery = "update dbo.Mobile set [Name]=@val1 ,BrandId=@val2 ,ProductionDate= @val3 ,[Weight]=@val4 ,Otg= @val5 ,UserId= @val6" +
                            " where  [Id]=@val7;";

            //SqlQueryBrand SQbrand = new SqlQueryBrand();
            //MobileDB.BrandId = SQbrand.GetBrandId(MobileDB);
            MobileDB.UserId = UserId;
            var connect = Connection.SqlConnectionObject;
            connect.Open();
            SqlCommand command = new SqlCommand(UpdateQuery, connect);
            command.Parameters.AddWithValue("@val1", MobileDB.Name);
            command.Parameters.AddWithValue("@val2", MobileDB.BrandId);
            command.Parameters.AddWithValue("@val3", MobileDB.ProductionDate);
            command.Parameters.AddWithValue("@val4", MobileDB.Weight);
            command.Parameters.AddWithValue("@val5", MobileDB.Otg);
            command.Parameters.AddWithValue("@val6", MobileDB.UserId);
            command.Parameters.AddWithValue("@val7", MobileDB.Id);

            var value = command.ExecuteNonQuery();
            connect.Close();

        }
        //public void Delete(Mobile MobileDB);

        public List<Mobile> GetMobileList(int UserId)
        {

            var connect = Connection.SqlConnectionObject;
            connect.Open();
            string Query = "select * from dbo.[Mobile] where UserId = @val1;";
            SqlCommand command = new SqlCommand(Query, connect);
            command.Parameters.AddWithValue("@val1", UserId);
            var rd = command.ExecuteReader();
            List<Mobile> MobileLi = new List<Mobile>();
            while (rd.Read())
            {
                Mobile MobileModel = new Mobile();
                MobileModel.Id = int.Parse(rd["Id"].ToString());
                MobileModel.Name = rd["Name"].ToString();
                MobileModel.BrandId = int.Parse(rd["BrandId"].ToString());
                MobileModel.ProductionDate = Convert.ToDateTime(rd["ProductionDate"].ToString());
                MobileModel.Weight = Convert.ToInt32(rd["Weight"].ToString());
                MobileModel.Otg = Convert.ToBoolean(rd["Otg"].ToString());
                MobileModel.UserId = int.Parse(rd["UserId"].ToString());

               

                MobileLi.Add(MobileModel);
            }
            return MobileLi;
        }
        public Mobile GetMobile(Mobile MobileDB )
        {

            var connect = Connection.SqlConnectionObject;
            connect.Open();
            string Query = "select top 1 *  from dbo.[Mobile] where [Name]= @val1 ORDER BY Id DESC ;";
            SqlCommand command = new SqlCommand(Query, connect);
            command.Parameters.AddWithValue("@val1", MobileDB.Name);
            var rd = command.ExecuteReader();
            Mobile MobileModel = new Mobile();
            while (rd.Read())
            {
                MobileModel.Id = int.Parse(rd["Id"].ToString());
                MobileModel.Name = rd["Name"].ToString();
                MobileModel.BrandId = int.Parse(rd["BrandId"].ToString());
                MobileModel.ProductionDate = Convert.ToDateTime(rd["ProductionDate"].ToString());
                MobileModel.Weight = Convert.ToInt32(rd["Weight"].ToString());
                MobileModel.Otg = Convert.ToBoolean(rd["Otg"].ToString());
                MobileModel.UserId = int.Parse(rd["UserId"].ToString());
                
            }
            return MobileModel;
        }
    }
}

