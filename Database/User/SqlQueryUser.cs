using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database.User
{
    public class SqlQueryUser
    {

        public void InsertUser(User UserModel)
        {
            var sqlQueryUser = "insert into dbo.[User] (FirstName , LastName , BirthDate , Phone ,Email ,RegisteryDate, UserName,[Password] )" +
                             "values (@val1 , @val2 , @val3 , @val4 , @val5 , @val6, @val7 ,@val8);";
            
            var connect = Connection.SqlConnectionObject;
            connect.Open();

            SqlCommand command = new SqlCommand(sqlQueryUser, connect);
            command.Parameters.AddWithValue("@val1", UserModel.FirstName);
            command.Parameters.AddWithValue("@val2", UserModel.LastName);
            command.Parameters.AddWithValue("@val3", UserModel.BirthDate);
            command.Parameters.AddWithValue("@val4", UserModel.Phones);
            command.Parameters.AddWithValue("@val5", UserModel.Email);
            command.Parameters.AddWithValue("@val6", UserModel.RegisteryDate);
            command.Parameters.AddWithValue("@val7", UserModel.UserName);
            command.Parameters.AddWithValue("@val8", UserModel.password);

            var value = command.ExecuteNonQuery();
            connect.Close();
        }
        public User GetUserLogin(User UserModel)
        {

            var connect = Connection.SqlConnectionObject;
            connect.Open();
            string Query = "select Id,UserName,[Password] from dbo.[User] where UserName=@val1";
            SqlCommand command = new SqlCommand(Query, connect);

            command.Parameters.AddWithValue("@val1", UserModel.UserName);


            var rd = command.ExecuteReader();
            User UserLi = new User();
            while (rd.Read())
            {
                User MobileModel = new User();
                UserModel.Id = int.Parse(rd["Id"].ToString());
                UserModel.UserName = rd["UserName"].ToString();
                UserModel.password = rd["password"].ToString();

            }
            return UserLi;
        }
        //public User GetUserLogin(User UserModel)
        //{

        //    var connect = Connection.SqlConnectionObject;
        //    connect.Open();
        //    string Query = "select Id,UserName,[Password] from dbo.[User] where UserName=@val1";
        //    SqlCommand command = new SqlCommand(Query, connect);

        //    command.Parameters.AddWithValue("@val1", UserModel.UserName);


        //    var rd = command.ExecuteReader();
        //    User UserLi = new User();
        //    while (rd.Read())
        //    {
        //        User MobileModel = new User();
        //        UserModel.Id = int.Parse(rd["Id"].ToString());
        //        UserModel.UserName = rd["UserName"].ToString();
        //        UserModel.password = rd["password"].ToString();

        //    }
        //    return UserLi;
        //}

    }
}