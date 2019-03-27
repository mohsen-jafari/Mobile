using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Database.Mobile;
using Database.Enum;
using Database.Mobile.Query;

namespace FormsMobile

{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            buttonCancel.Visible = false;
        }
        string MobileImage;
        List<MobileVM> MobaileArray = new List<MobileVM>();
        string Name1;
        int i = 0;
        BrandEnum? BrandName = null;
        //DateTime ProductionDate;
        int Weight;
        bool Otg;
        NetworkEnum? G2;
        NetworkEnum? G3;
        NetworkEnum? G4;
        int length;
        int UserId = UserSession.Id;
        
        public object SqlQueryMobile1 { get; private set; }

        // button Record ////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Name1 == null || Name1 == "" || textBoxName == null || textBoxName.Text.Length == 0 )
            {
                checkTBName();
            }
            else
            {
                BuildMobile();
                buttonAddMoile.Visible = true;
                buttonCancel.Visible = false;
                errorProvider1.SetError(textBoxName, "");
            }
            
        }

        //  button back  /////////////////////////////////////////////////////////////////
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (length > 0)
            {
                length--;
                seeHistory(length);
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {

            if (length < i - 1)
            {
                length++;
                seeHistory(length);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Otg = chBoxOtg.Checked;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBrand(listBoxBrand.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InPutDatabase();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Name1 = textBoxName.Text;
            if (Name1 == null)
            {
                Name1 = textBoxName.Text;
            }
        }


        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxWeight.Text, out Weight))
            {
                textBoxWeight.Clear();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            bool Ch2g = chBox2g.Checked;
            if (Ch2g == true)
            {
                G2 = NetworkEnum.G2;
            }
            else
            {
                G2 = null;
            }

        }

        private void chBox3g_CheckedChanged(object sender, EventArgs e)
        {
            bool Ch3g = chBox3g.Checked;
            if (Ch3g == true)
            {
                G3 = NetworkEnum.G3;
            }
            else
            {
                G3 = null;
            }
        }

        private void chkBox4g_CheckedChanged(object sender, EventArgs e)
        {
            bool Ch4g = chBox4g.Checked;
            if (Ch4g == true)
            {
                G4 = NetworkEnum.G4;
            }
            else
            {
                G4 = null;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            var item = openFileDialog1.ShowDialog();
            if (item == DialogResult.OK)
            {
                TakeFileName(openFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void TakeFileName(string inFileNameAddress)
        {

            MobileImage = inFileNameAddress;
            var image = new Bitmap(MobileImage);
            pictureBox1.Image = image;

        }

        public void seeHistory(int length)
        {
            //InPutDatabase();

            textBoxName.Text = Convert.ToString(MobaileArray[length].Name);
            listBoxBrand.Text = Convert.ToString(MobaileArray[length].BrandName);
            dateTimePicker1.Value = Convert.ToDateTime(MobaileArray[length].ProductionDate);
            textBoxWeight.Text = Convert.ToString(MobaileArray[length].Weight);
            chBoxOtg.Checked = MobaileArray[length].Otg;

            chBox2g.Checked = (MobaileArray[length].Networks[0] == null ? false : true);
            chBox3g.Checked = (MobaileArray[length].Networks[1] == null ? false : true);
            chBox4g.Checked = (MobaileArray[length].Networks[2] == null ? false : true);

            if (MobaileArray[length].Image.FileNameAddress != null)
            {
                var image = new Bitmap(MobaileArray[length].Image.FileNameAddress);
                pictureBox1.Image = image;
            }
            else if (MobaileArray[length].Image.FileNameAddress == null)
            {
                pictureBox1.Image = null;
            }
        }

        public BrandEnum? GetBrand(string listbrand)
        {

            if (listbrand == "apple")
            {
                BrandName = BrandEnum.apple;
            }
            else if (listbrand == "Xiaomi")
            {
                BrandName = BrandEnum.Xiaomi;
            }
            else if (listbrand == "Samsung")
            {
                BrandName = BrandEnum.Samsung;
            }
            else if (listbrand == "LG")
            {
                BrandName = BrandEnum.LG;
            }
            return BrandName;
        }

        private void buttonUpload1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //MobileXml MobileXml = new MobileXml();
            //MobileXml.WriteMobileXml(MobaileArray);
        }

        private void buttonListShow_Click(object sender, EventArgs e)
        {
            ListForm FormShow = new ListForm();
            FormShow.Show();
            //FormShow.MobileGrid = MobaileArray;
            //FormShow.MobileGrid = FormShow.GetMobileView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public List<MobileVM> InPutDatabase()
        {
             MobaileArray = new List<MobileVM>();
              i = 0;
            //foreach (var item in MobaileArray)
            //{
            //    MobaileArray.Remove(item);
            //}
            //MobaileArray.Clear();


            SqlQueryMobile SqlQueryMobileMod = new SqlQueryMobile();

            var MobileList = SqlQueryMobileMod.GetMobileList(UserId);
            

            foreach (var item in MobileList)
            {
                MobileVM vm = new MobileVM();
                vm.Number = item.Id;
                vm.Name = item.Name;
                //vm.BrandName = item.BrandN.Name;
                vm.ProductionDate = item.ProductionDate;
                vm.Weight = item.Weight;
                vm.Otg = item.Otg;
                //vm.Networks = item.Network.Networks; 

                SqlQueryBrand SQbrand = new SqlQueryBrand();
                var Brand = SQbrand.GetBrandName(item.BrandId);
                vm.BrandName = Brand.Name;

                SqlQueryNetworkMobile SQMobileNetwork = new SqlQueryNetworkMobile();
                var NetworkCl = SQMobileNetwork.GetMobileNetwork(item);
                vm.Networks = NetworkCl.Networks.ToArray();

                SqlQueryMobileImage SQMobileImage = new SqlQueryMobileImage();
                var ImageCl = SQMobileImage.GetMobileImage(item);
                vm.Image = new ImageMobile(ImageCl.ImageAddress);
                MobaileArray.Add(vm);
                i++;
                length = i;
            }
            return MobaileArray;
        }


        private void buttonAddMoile_Click(object sender, EventArgs e)
        {
            length = i;
            buttonBack.Enabled = false;
            buttonForward.Enabled = false;
            textBoxName.Clear();
            listBoxBrand.ClearSelected();
            textBoxWeight.Clear();
            //pictureBox1.InitialImage = null;
            pictureBox1.Image = null;
            chBox2g.Checked = false;
            chBox3g.Checked = false;
            chBox4g.Checked = false;
            chBoxOtg.Checked = false;
            buttonCancel.Visible = true;
            buttonAddMoile.Visible = false;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonBack.Enabled = true;
            buttonForward.Enabled = true;
            textBoxName.Clear();
            listBoxBrand.ClearSelected();
            textBoxWeight.Clear();
            pictureBox1.Image = null;
            chBox2g.Checked = false;
            chBox3g.Checked = false;
            chBox4g.Checked = false;
            chBoxOtg.Checked = false;
            buttonAddMoile.Visible = true;
            buttonCancel.Visible = false;
        }
        public void BuildMobile()
        {
            MobileVM MobileModel = new MobileVM();
            MobileModel.Networks = new NetworkEnum?[3];

            MobileModel.Networks[0] = G2;
            MobileModel.Networks[1] = G3;
            MobileModel.Networks[2] = G4;

            MobileModel.Name = Name1;
            MobileModel.BrandName = BrandName;
            MobileModel.ProductionDate = Convert.ToDateTime(dateTimePicker1.Text);
            MobileModel.Weight = Weight;
            MobileModel.Otg = Otg;

            if (i != length)
            {

                MobileModel.Image = new ImageMobile(MobaileArray[length].Image.FileNameAddress);

            }
            else
            {
                MobileModel.Image = new ImageMobile(MobileImage);
            }

            if (MobileModel.Name != "")
            {
                Mobile MobileDB = new Mobile();
                MobileDB.Name = MobileModel.Name;
                //MobileDB.BrandN = new Brand(MobileModel.BrandName);
                MobileDB.ProductionDate = MobileModel.ProductionDate;
                MobileDB.Weight = MobileModel.Weight;
                MobileDB.Otg = MobileModel.Otg;

                Brand brandDB = new Brand();
                brandDB.Name = MobileModel.BrandName;

                Network NetworkDB = new Network();
                NetworkDB = new Network(MobileModel.Networks);

                Database.Mobile.Image ImageDB = new Database.Mobile.Image();
                
                MobileModel.Image = new ImageMobile(MobileModel.Image.FileNameAddress);
                ImageDB = new Database.Mobile.Image(MobileModel.Image.FileNameAddress);

                if (length == i)
                {
                    SqlQueryBrand SQbrand = new SqlQueryBrand();
                    MobileDB.BrandId = SQbrand.GetBrandId(brandDB);

                    SqlQueryMobile SQMobile = new SqlQueryMobile();
                    SQMobile.InsertMobile(MobileDB, UserId);
                    
                    SqlQueryImage SQImage = new SqlQueryImage();
                    SQImage.InsertImage(ImageDB);

                    SqlQueryMobileImage SQMobileImage = new SqlQueryMobileImage();
                    SQMobileImage.InsertId(MobileDB , ImageDB);

                    if (NetworkDB.Networks[0].HasValue)
                    {
                        int G2 = 0;
                        SqlQueryNetworkMobile SQMobileNetwork = new SqlQueryNetworkMobile();
                        SQMobileNetwork.InsertId(MobileDB, NetworkDB, G2);
                    }
                    if (NetworkDB.Networks[1].HasValue)
                    {
                        int G3 = 1;
                        SqlQueryNetworkMobile SQMobileNetwork = new SqlQueryNetworkMobile();
                        SQMobileNetwork.InsertId(MobileDB, NetworkDB, G3);
                    }
                    if (NetworkDB.Networks[2].HasValue)
                    {
                        int G4 = 2;
                        SqlQueryNetworkMobile SQMobileNetwork = new SqlQueryNetworkMobile();
                        SQMobileNetwork.InsertId(MobileDB, NetworkDB, G4);
                    }
                    var Image = SQImage.GetImage(ImageDB);
                    var Mobile = SQMobile.GetMobile(MobileDB);

                }
                else if (length != i)
                {
                    int id = MobaileArray[length].Number;
                    MobileDB.Id = id;
                    SqlQueryMobile SqlQueryMobileMod = new SqlQueryMobile();

                    SqlQueryBrand SQbrand = new SqlQueryBrand();
                    MobileDB.BrandId = SQbrand.GetBrandId(brandDB);

                    SqlQueryMobileMod.UpdateMobile(MobileDB, UserId);

                    SqlQueryMobileImage SQMI = new SqlQueryMobileImage();
                    var ImageinPut = SQMI.GetMobileImage(MobileDB );

                    SqlQueryImage SQImage = new SqlQueryImage();
                    SQImage.UpdateImage(ImageDB , ImageinPut);

                    SqlQueryNetworkMobile SQNM = new SqlQueryNetworkMobile();
                    SQNM.DeleteNetwork(MobileDB);

                    if (NetworkDB.Networks[0].HasValue)
                    {
                        int G2 = 0;
                        SqlQueryNetworkMobile SQMobileNetwork = new SqlQueryNetworkMobile();
                        SQMobileNetwork.InsertId(MobileDB, NetworkDB, G2);
                    }
                    if (NetworkDB.Networks[1].HasValue)
                    {
                        int G3 = 1;
                        SqlQueryNetworkMobile SQMobileNetwork = new SqlQueryNetworkMobile();
                        SQMobileNetwork.InsertId(MobileDB, NetworkDB, G3);
                    }
                    if (NetworkDB.Networks[2].HasValue)
                    {
                        int G4 = 2;
                        SqlQueryNetworkMobile SQMobileNetwork = new SqlQueryNetworkMobile();
                        SQMobileNetwork.InsertId(MobileDB, NetworkDB, G4);
                    }
                    //MobaileArray = new List<MobileVM>();
                    //MobaileArray.Clear();
                    //MobaileArray[length] = MobileModel;
                    length = i;
                }
            }

            textBoxName.Clear();
            listBoxBrand.ClearSelected();
            textBoxWeight.Clear();
            buttonBack.Enabled = true;
            buttonForward.Enabled = true;
            chBox2g.Checked = false;
            chBox3g.Checked = false;
            chBox4g.Checked = false;
            chBoxOtg.Checked = false;
            InPutDatabase();
        }
        public void checkTBName()
        {
                errorProvider1.SetError(textBoxName, "نام را وارد کنید");
                errorProvider1.SetIconAlignment(textBoxName, ErrorIconAlignment.MiddleLeft);
        }
    } 
}


