//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//namespace Database.Mobile.Query
//{
//    class SqlQueryMoileView
//    {
//        public List<Mobile> GetMobileList(int UserId)
//        {

//            var connect = Connection.SqlConnectionObject;
//            connect.Open();
//            string Query = "select * from dbo.[MobileReportView] where UserId = @val1;";
//            SqlCommand command = new SqlCommand(Query, connect);
//            command.Parameters.AddWithValue("@val1", UserId);
//            var rd = command.ExecuteReader();
//            List<MobileView> MobileLi = new List<MobileView>();
//            while (rd.Read())
//            {
//                MobileView MobileModel = new MobileView();
//                MobileModel.Id = int.Parse(rd["Id"].ToString());
//                MobileModel.Name = rd["Name"].ToString();
//                MobileModel.Brand = rd["BrandId"].ToString();
//                MobileModel.ProductionDate = Convert.ToDateTime(rd["ProductionDate"].ToString());
//                MobileModel.Weight = Convert.ToInt32(rd["Weight"].ToString());
//                MobileModel.Otg = Convert.ToBoolean(rd["Otg"].ToString());
//                MobileModel.UserId = int.Parse(rd["UserId"].ToString());
//                MobileModel.UserName= rd["UserName"].ToString();
//                MobileModel.Network = 

//                //SqlQueryBrand SQBid = new SqlQueryBrand();
//                //MobileModel.BrandN = SQBid.GetBrandName(MobileModel);

//                //SqlQueryImage SQImage = new SqlQueryImage();
//                //MobileModel.ImageC = SQImage.GetImage(MobileModel);

//                MobileLi.Add(MobileModel);
//            }
//            connect.Close();
//            return MobileLi;
//        }
//    }
//}
