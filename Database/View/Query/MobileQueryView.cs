using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Mobile;
using System.Data.SqlClient;
using Database.Mobile.Query;

namespace Database.View.Query
{
   public class MobileQueryView
    {
        public List<MobileView> GetMobileListView(int UserId)
        {
            
            var connect = Connection.SqlConnectionObject;
            connect.Open();
            string Query = "select * from dbo.[MobileReportView] where UserId = @val1;";
            SqlCommand command = new SqlCommand(Query, connect);
            command.Parameters.AddWithValue("@val1", UserId);
            var rd = command.ExecuteReader();

            SqlQueryBrand SQBRand = new SqlQueryBrand();
            List<MobileView> MobileLi = new List<MobileView>();

            while (rd.Read())
            {
                MobileView MobileModel = new MobileView();
                MobileModel.Id = int.Parse(rd["MobileId"].ToString());
                MobileModel.Name = rd["Name"].ToString();
                MobileModel.BrandN = SQBRand.GetBrandEnum(rd["Brand"].ToString());
                MobileModel.ProductionDate = Convert.ToDateTime(rd["ProductionDate"].ToString());
                MobileModel.Weight = Convert.ToInt32(rd["Weight"].ToString());
                MobileModel.Otg = Convert.ToBoolean(rd["Otg"].ToString());
                MobileModel.UserId = int.Parse(rd["UserId"].ToString());
                MobileModel.UserName = rd["UserName"].ToString();

                //MobileModel.Image = rd["ImageAddress"].ToString();

                SqlQueryNetworkMobile SQNetworkView = new SqlQueryNetworkMobile();
                var Network = SQNetworkView.GetMobileNetworkView(MobileModel);  
                MobileModel.Networks = Network.Networks;

                SqlQueryMobileImage SQImageView = new SqlQueryMobileImage();
                var Image = SQImageView.GetMobileImageView(MobileModel);
                MobileModel.Image = Image.ImageAddress;


                MobileLi.Add(MobileModel);
            }
            return MobileLi;
        }
    }
}