using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMobile
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        Mobile MobailArray = new Mobile();

        private void button1_Click(object sender, EventArgs e)
        {
            


            //var listbrand = Convert.ToSingle(listBoxBrand.SelectedItem);
            

            MobailArray.ProductionDate = Convert.ToDateTime(dateTimePicker1.Text);



            //MessageBox.Show(
            //    MobailArray.Name,
            //    Convert.ToString(MobailArray.BrandName)
            //    );
            //MessageBox.Show(
            //    Convert.ToString(MobailArray.ProductionDate),
            //    Convert.ToString(MobailArray.Weight)
            //    );


            textBoxMessage.Text = " Name Mobile :" + MobailArray.Name + 
                                  " Brand  :" + Convert.ToString(MobailArray.BrandName) +
                                  " Production Date :" + Convert.ToString(MobailArray.ProductionDate) +
                                  " Weight Mobile :" + Convert.ToString(MobailArray.Weight);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var listbrand = listBoxBrand.Text;

            if (listbrand == "apple")
            {
                MobailArray.BrandName = Brand.apple;
            }
            else if (listbrand == "Xiaomi")
            {
                MobailArray.BrandName = Brand.Xiaomi;
            }
            else if (listbrand == "Samsung")
            {
                MobailArray.BrandName = Brand.Samsung;
            }
            else if (listbrand == "lg")
            {
                MobailArray.BrandName = Brand.apple;
            }
            else
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            MobailArray.Name = textBoxName.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MobailArray.ProductionDate = Convert.ToDateTime(dateTimePicker1.Text);
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            
            if (!int.TryParse(textBoxWeight.Text, out MobailArray.Weight))
                {
                   //textBoxWeight.Clear();
                   MessageBox.Show(" لطفا وزن را عدد وارد کنید ");
                }
        }
        private void ChOtgNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            textBoxName.Clear();
            listBoxBrand.ClearSelected();

            //textBoxWeight.Clear();
            //listBoxBrand.Items.Clear();
            //listBoxBrand.Items.Remove(listBoxBrand.SelectedItem); 


        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            //textBoxMessage.Text = "Name Mobile :" + MobailArray.Name +
            //                      "Brand Mobile :" + Convert.ToString(MobailArray.BrandName) +
            //                      "Brand Mobile :" + Convert.ToString(MobailArray.ProductionDate) +
            //                      "Brand Mobile :" + Convert.ToString(MobailArray.Weight);
        }


    }
}
