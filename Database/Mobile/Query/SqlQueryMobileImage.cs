using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Database.View;
namespace Database.Mobile.Query
{
    public class SqlQueryMobileImage
    {
        public void InsertId(Mobile MobileDB ,Image ImageDB)
        {
            SqlQueryImage SQImage = new SqlQueryImage();
            var Image = SQImage.GetImage(ImageDB);
            SqlQueryMobile SQMobile = new SqlQueryMobile();
            var Mobile = SQMobile.GetMobile(MobileDB);

            if (Image.Id != 0)
            {
                var InsertMobileQuery = "insert into dbo.[MobileImage] (MobileId,ImageId) values ( @val1, @val2 );";

                var connect = Connection.SqlConnectionObject;
                SqlQueryBrand SQbrand = new SqlQueryBrand();

                connect.Open();
                

                SqlCommand command = new SqlCommand(InsertMobileQuery, connect);
                command.Parameters.AddWithValue("@val1", Mobile.Id);
                command.Parameters.AddWithValue("@val2", Image.Id);

                var value = command.ExecuteNonQuery();
                connect.Close();

            }
           
        }

        public Image GetMobileImage(Mobile MobileDB)
        {
            //var Name = MobileDB.Brand.;
            var connect = Connection.SqlConnectionObject;
            connect.Open();
            
            //string Query = String.Format("SELECT   FROM " +
            //"dbo.Mobile LEFT JOIN dbo.MobileImage ON dbo.Mobile.Id = dbo.MobileImage.MobileId LEFT JOIN " +
            //"dbo.Image ON dbo.MobileImage.ImageId = dbo.Image.Id  where dbo.Mobile.Id = {0}", MobileDB.Id);

            string Query = string.Format("select * from dbo.MobileImageView where Id={0};", MobileDB.Id);

            SqlCommand command = new SqlCommand(Query, connect);
            var rd = command.ExecuteReader();
            Image ImageQ = new Image();
            //MobileQ.ImageC = new Image();
            while (rd.Read())
            {
                ImageQ.Id = int.Parse(rd["ImageId"].ToString());
                ImageQ.ImageAddress= rd["ImageAddress"].ToString();
            }
            connect.Close();

            return ImageQ;
        }

        public Image GetMobileImageView(MobileView MobileVI)
        {
            //var Name = MobileDB.Brand.;
            var connect = Connection.SqlConnectionObject;
            connect.Open();

            //string Query = String.Format("SELECT   FROM " +
            //"dbo.Mobile LEFT JOIN dbo.MobileImage ON dbo.Mobile.Id = dbo.MobileImage.MobileId LEFT JOIN " +
            //"dbo.Image ON dbo.MobileImage.ImageId = dbo.Image.Id  where dbo.Mobile.Id = {0}", MobileDB.Id);

            string Query = string.Format("select * from dbo.MobileImageView where Id={0};", MobileVI.Id);

            SqlCommand command = new SqlCommand(Query, connect);
            var rd = command.ExecuteReader();
            Image ImageQ = new Image();
            //MobileQ.ImageC = new Image();
            while (rd.Read())
            {
                ImageQ.Id = int.Parse(rd["ImageId"].ToString());
                ImageQ.ImageAddress = rd["ImageAddress"].ToString();
            }
            connect.Close();

            return ImageQ;
        }
    }
}
