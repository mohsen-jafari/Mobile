using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Enum;
namespace FormsMobile
{
    public static class Message
    {
        public static string GetMessageLine(MobileVM a)
        {

            string rusalt = " Name Mobile: " + a.Name +
                            " Brand: " + Convert.ToString(a.BrandName) +
                            " Production Date: " + Convert.ToString(a.ProductionDate)+
                            " Weight Mobile: " + Convert.ToString(a.Weight)+
                            " Support from otg: " + Convert.ToString(a.Otg ? "Yes" : "NO") +
                            " Network Suport: " + PrintMobileModelList(a.Networks)+
                            " File Image Address: " + a.Image.FileNameAddress;

            return rusalt;
        }

        public static string GetMessageUpload(MobileVM a)
        {

            string rusalt = " Name Mobile: " + a.Name +","+
                            " Brand: " + Convert.ToString(a.BrandName) +"," +
                            " Production Date: " + Convert.ToString(a.ProductionDate) +"," +
                            " Weight Mobile: " + Convert.ToString(a.Weight) + "," +
                            " Support from otg: " + Convert.ToString(a.Otg ? "Yes" : "NO") + "," +
                            " Networks Suport: " + PrintMobileModelList(a.Networks) + "," +
                            " File Image Address: " + a.Image.FileNameAddress + "|" + "\t \t \t \t  \n \n \n ";

            return rusalt;
        }
        private static string PrintMobileModelList(NetworkEnum?[] Networks1)
        {
            var Result = "";
            foreach (var item in Networks1)
            {
                var Result1 = item.ToString();

                Result = Result + " " + Result1;
            }
            return Result;
        }
    }
}
