using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Database.Mobile.Query
{
    public class SqlQueryImage
    {
        public void InsertImage(Image ImageDB)
        {
           
            if(ImageDB.ImageAddress != null)
            {
                var InsertMobileQuery = "insert into dbo.[Image] (ImageAddress)values (@val1);";
                var connect = Connection.SqlConnectionObject;
                //SqlQueryBrand SQbrand = new SqlQueryBrand();

                connect.Open();

                SqlCommand command = new SqlCommand(InsertMobileQuery, connect);
                command.Parameters.AddWithValue("@val1", ImageDB.ImageAddress);
                var value = command.ExecuteNonQuery();
                connect.Close();
            }
        }

        public Image GetImage(Image ImageDB)
        {
                //var Name = MobileDB.Brand.;
                var connect = Connection.SqlConnectionObject;
                connect.Open();
                Image ImageQ = new Image();
                //MobileQ.ImageC = new Image();
            if (ImageDB.ImageAddress != null)
            {
                string Query = "select top 1 Id , ImageAddress from dbo.[Image] where [ImageAddress]= @val1";
                SqlCommand command = new SqlCommand(Query, connect);
                command.Parameters.AddWithValue("@val1", ImageDB.ImageAddress);
                var rd = command.ExecuteReader();
                
                while (rd.Read())
                {
                    ImageQ = new Image(int.Parse(rd["Id"].ToString()));
                    ImageQ.ImageAddress = rd["ImageAddress"].ToString();
                    ImageQ.Id = int.Parse(rd["Id"].ToString());
                }

                connect.Close();
            }
                return ImageQ;
        }

        public void UpdateImage(Image ImageDB, Image ImageInPut)
        {
            string UpdateQuery = "update dbo.Image set [ImageAddress] = @val1 where [Id] = @val2;";

            //SqlQueryBrand SQbrand = new SqlQueryBrand();
            //MobileDB.BrandId = SQbrand.GetBrandId(MobileDB);

            var connect = Connection.SqlConnectionObject;
            connect.Open();
            SqlCommand command = new SqlCommand(UpdateQuery, connect);
            command.Parameters.AddWithValue("@val1", ImageDB.ImageAddress);
            command.Parameters.AddWithValue("@val2", ImageInPut.Id);

            var value = command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
