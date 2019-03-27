using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using System.Data.SqlClient;
using Database.User;

namespace FormsMobile
{
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (checkSignUp())
            {
                if (checkTrySignUp())
                {
                    User User = new User();
                    User.UserName = TBUserName.Text;
                    SqlQueryUser QueryUser = new SqlQueryUser();

                    QueryUser.GetUserLogin(User);

                    if (User.Id == 0)
                    {
                        var InfoUser = GetInfoUser();
                        var UserModel = BuildUserModel(InfoUser);
                        SqlQueryUser SQUser = new SqlQueryUser();
                        SQUser.InsertUser(UserModel);
                        MessageBox.Show("ثبت نام با موفقیت انجام شد ", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری از قبل ثبت شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var name = TBFirstName.Text;
            int s;
            if (int.TryParse(name, out s))
            {
                errorProvider1.SetError(TBFirstName, "عدد وارد نکنید");

                errorProvider1.SetIconAlignment(TBFirstName, ErrorIconAlignment.MiddleLeft);

            }
        }

        private void UserSignUp_Load(object sender, EventArgs e)
        {

        }

        private void TextUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public UserVM GetInfoUser()
        {
            UserVM UserVMModel = new UserVM();

            UserVMModel.FirstName = TBFirstName.Text;
            UserVMModel.LastName = TBLastName.Text;
            UserVMModel.BirthDate = Convert.ToDateTime(TBBirthDate.Text);
            UserVMModel.Phones = Convert.ToDouble(TBPhone.Text);

            //if (TBBirthDate.Text != null && TBBirthDate.Text != "")
            //{
            //    UserVMModel.BirthDate = Convert.ToDateTime(TBBirthDate.Text);
            //}
            //else
            //{
            //    UserVMModel.BirthDate = null;
            //}

            //if (UserVMModel.Phones != null && TBPhone.Text == "")
            //{
            //    UserVMModel.Phones = Convert.ToInt32(TBPhone.Text);
            //}
            //else
            //{
            //    UserVMModel.Phones = null;
            //}

            UserVMModel.UserName = TBUserName.Text;
            UserVMModel.Email = TBEmail.Text;
            UserVMModel.password = TBpassword.Text;
            UserVMModel.RegisteryDate = DateTime.Now;

            return UserVMModel;
        }

        public User BuildUserModel(UserVM UserVMModel)
        {
            User UserModel = new User();

            UserModel.FirstName = UserVMModel.FirstName;
            UserModel.LastName = UserVMModel.LastName;
            UserModel.BirthDate = UserVMModel.BirthDate;
            UserModel.Phones = UserVMModel.Phones;
            UserModel.Email = UserVMModel.Email;
            UserModel.UserName = UserVMModel.UserName;
            UserModel.password = UserVMModel.password;
            UserModel.RegisteryDate = UserVMModel.RegisteryDate;

            return UserModel;
        }
        public bool checkSignUp()
        {
            bool check = true;
            if (TBFirstName.Text == null || TBFirstName.Text == "")
            {
                errorProvider1.SetError(TBFirstName, "نام را وارد کنید");

                errorProvider1.SetIconAlignment(TBFirstName, ErrorIconAlignment.MiddleLeft);
                check = false;
            }
            else
            {
                errorProvider1.SetError(TBFirstName, "");
            }
            if (TBLastName.Text == null || TBLastName.Text == "")
            {
                errorProvider1.SetError(TBLastName, "نام  خانوادگی را وارد کنید");

                errorProvider1.SetIconAlignment(TBLastName, ErrorIconAlignment.MiddleLeft);
                check = false;
            }
            else
            {
                errorProvider1.SetError(TBLastName, "");
            }
            if (TBBirthDate.Text == null || TBBirthDate.Text == "")
            {
                errorProvider1.SetError(TBBirthDate, "تاریخ تولد را وارد کنید");

                errorProvider1.SetIconAlignment(TBBirthDate, ErrorIconAlignment.MiddleLeft);
                check = false;
            }
            else
            {
                errorProvider1.SetError(TBBirthDate, "");
            }
            if (TBPhone.Text == null || TBPhone.Text == "")
            {
                errorProvider1.SetError(TBPhone, "شماره تلفن را وارد کنید");

                errorProvider1.SetIconAlignment(TBPhone, ErrorIconAlignment.MiddleLeft);
                check = false;
            }
            else
            {
                errorProvider1.SetError(TBPhone, "");
            }
            if (TBUserName.Text == null || TBUserName.Text == "")
            {
                errorProvider1.SetError(TBUserName, "نام کاربری را وارد کنید");

                errorProvider1.SetIconAlignment(TBUserName, ErrorIconAlignment.MiddleLeft);
                check = false;
            }
            else
            {
                errorProvider1.SetError(TBUserName, "");
            }
            if (TBpassword.Text == null || TBpassword.Text == "")
            {
                errorProvider1.SetError(TBpassword, "  پسورد را وارد کنید");

                errorProvider1.SetIconAlignment(TBpassword, ErrorIconAlignment.MiddleLeft);
                check = false;
            }
            else
            {
                errorProvider1.SetError(TBpassword, "");
            }
            if (TBEmail.Text == null || TBEmail.Text == "")
            {
                errorProvider1.SetError(TBEmail, "ایمیل را وارد کنید");

                errorProvider1.SetIconAlignment(TBEmail, ErrorIconAlignment.MiddleLeft);
                check = false;
            }
            else
            {
                errorProvider1.SetError(TBEmail, "");
            }
            return check;
        }
        public bool checkTrySignUp()
        {
            bool checkTry = true;

            var name = TBFirstName.Text;
            int s;
            if (int.TryParse(name, out s))
            {
                errorProvider1.SetError(TBFirstName, "عدد وارد نکنید");

                errorProvider1.SetIconAlignment(TBFirstName, ErrorIconAlignment.MiddleLeft);
                checkTry = false;
            }
            else
            {
                errorProvider1.SetError(TBFirstName, "");
            }
            if (TBEmail.Text.Contains("@") && TBEmail.Text.Contains("."))
            {
                errorProvider1.SetError(TBEmail, "");
            }
            else
            {
                errorProvider1.SetError(TBEmail, "آیمیل را به طور صحیح وارد کنید");

                errorProvider1.SetIconAlignment(TBEmail, ErrorIconAlignment.MiddleLeft);

                checkTry = false;
            }
            if (TBPhone.TextLength < 10)
            {
                errorProvider1.SetError(TBPhone, "شماره تلفن را به طور صحیح وارد کنید ");

                errorProvider1.SetIconAlignment(TBPhone, ErrorIconAlignment.MiddleLeft);

                checkTry = false;
            }
            else
            {
                errorProvider1.SetError(TBPhone, "");
            }
            var Phone = TBPhone.Text;
            int d;
            if (int.TryParse(Phone, out d))
            {
                errorProvider1.SetError(TBPhone, "عدد وارد کنید");

                errorProvider1.SetIconAlignment(TBPhone, ErrorIconAlignment.MiddleLeft);

                checkTry = false;
            }
            else
            {
                errorProvider1.SetError(TBPhone, "");
            }

            return checkTry;
        }
    }
}
