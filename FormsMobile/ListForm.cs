using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.View;
using Database.View.Query;
using Database.Mobile.Query;
namespace FormsMobile
{
    public partial class ListForm : Form
    {
        public ListForm()
        {

            InitializeComponent();
            CBSearchBrand.SelectedIndex = 0;
            
            
        }

        public List<MobileView> MobileGrid = new List<MobileView>();
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            showGridView();

        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        public void SearchMobileX()
        {
            GetMobileView();
            foreach (var item in MobileGrid)
            {

                if (item != null)
                {
                    if (item.Name.Contains(SearchMobile.SearchName) && Convert.ToString(item.BrandN) == SearchMobile.SearchBrand)
                    {
                        AddRowItem(item);

                    }
                    else if (item.Name.Contains(SearchMobile.SearchName) && CBSearchBrand.SelectedIndex == 0)
                    {
                        AddRowItem(item);
                    }
                    else if (Convert.ToString(item.BrandN) == SearchMobile.SearchBrand && SearchMobile.SearchName == "")
                    {
                        AddRowItem(item);
                    }
                }
            }

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("نمایش کل لیست", " مشخصات جستجو شده در لیست نیست  ");

                showGridView();
            }
        }

        private void TBSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBSearchBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            SearchMobile.SearchName = TBSearchName.Text;
            SearchMobile.SearchBrand = CBSearchBrand.Text;

            if (SearchMobile.SearchName != "" || CBSearchBrand.SelectedIndex != 0)
            {
                SearchMobileX();
            }
            else
            {
                MessageBox.Show("نمایش کل لیست", " قسمت جستجو پر نشده است  ");

                showGridView();
            }

            CBSearchBrand.SelectedIndex = 0;
        }


        public void showGridView()
        {
            dataGridView1.Rows.Clear();
            GetMobileView();
            foreach (var item in MobileGrid)
            {

                if (item != null)
                {
                    AddRowItem(item);
                }
            }
        }

        public void AddRowItem(MobileView item)
        {

            dataGridView1.Rows.Add(item.Name, item.BrandN, item.ProductionDate, item.Weight, item.Otg , string.Format(" {0} {1} {2} ",
                                   item.Networks[0], item.Networks[1], item.Networks[2]), item.Image,item.UserName);

        }
        public List<MobileView> GetMobileView()
        {
            MobileQueryView MQview = new MobileQueryView();

            int UserId = UserSession.Id;
            MobileGrid = MQview.GetMobileListView(UserId);
            return MobileGrid;
        }
    }
}
