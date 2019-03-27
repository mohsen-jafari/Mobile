using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Database.User;
namespace FormsMobile
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }



        List<UserVM> UsersArray = new List<UserVM>();
        string Password;
        string Username;
        //int i = 0;
        //string PathUser = @"C:\Users\Glass\Desktop\Mobile\Users.xml";
        //bool Repeat = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            Username = textBoxUser.Text;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            Password = textBoxPass.Text;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Username != null && Username != "" && Password != null && Password != "")
            {
                ReadUser();
                textBoxPass.Clear();
                textBoxUser.Clear();
            }
            else
            {
                MessageBox.Show("تمام قسمت ها به طور کامل پر شود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            UserSignUp UserSignUp = new UserSignUp();
            UserSignUp.Show();
            //this.Hide();
            //BuildUserXml();
        }

       

        public void ReadUser()
        {
            User UserModel = new User();
            UserModel.UserName = Username;
            SqlQueryUser SQUser = new SqlQueryUser();

            SQUser.GetUserLogin(UserModel);
            //int Id = UserModel.Id;

            if (Username == UserModel.UserName && Password == UserModel.password)
            {
               
                    UserSession.UserName = UserModel.UserName;
                    UserSession.Id = UserModel.Id;
                    //User.GetUserName(UserModel.Id);
                    HomeForm HomeShow = new HomeForm();
                    HomeShow.Show();
                    this.Hide();
               
            }
            else if (Username == UserModel.UserName && Password != UserModel.password)
            {
                MessageBox.Show("نام کاربری یا گذرواژه صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        
        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
