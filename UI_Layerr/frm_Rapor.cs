using DataAccessLayer.Context;
using Enitities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layerr
{
    public partial class frm_Rapor : Form
    {
        Context db = new Context();
        public frm_Rapor()
        {
            InitializeComponent();
        }
        public int GelenID;
        public frm_Rapor(int ID)
        {
            InitializeComponent();
            GelenID = ID;



        }
        private void frm_Rapor_Load(object sender, EventArgs e)
        {
            rjComboBox1.Items.Add("Kahvaltıda en çok yediklerim");
            rjComboBox1.Items.Add("Öğle yemeğinde en çok yediklerim");
            rjComboBox1.Items.Add("Akşam yemeğinde en çok yediklerim");
            rjComboBox1.Items.Add("Ara Öğünlerde en çok yediklerim");
            rjComboBox1.Items.Add("tüm zamanlarda en çok yediklerim");

            float Toplam = 0;
            var que = db.Meals.Where(x => x.UserDetailID == GelenID && x.TüketimTarihi.Year == rjDatePicker1.Value.Year && x.TüketimTarihi.Month == rjDatePicker1.Value.Month && x.TüketimTarihi.Day == rjDatePicker1.Value.Day).ToList();
            foreach (var item in que)
            {
                Toplam += item.TopKcall;
            }
            label1.Text = Toplam.ToString();
        }
        DateTime Bugün = DateTime.Now;
        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rjComboBox1.SelectedIndex == 0)
                {
                    var query = db.Meals.Where(x => x.UserDetailID == GelenID && x.MealType == Enitities.Enums.MealType.Kahvaltı).GroupBy(x => x.FoodInfoID).OrderBy(x => x.Count()).FirstOrDefault().ToList();
                    int deneme = (int)query.Select(x => x.FoodInfoID).FirstOrDefault();
                    var query2 = db.FoodInfos.Where(x => x.FoodInfoID == deneme).ToList();

                    dataGridView1.DataSource = query2;


                }
                else if (rjComboBox1.SelectedIndex == 1)
                {
                    var query = db.Meals.Where(x => x.UserDetailID == GelenID && x.MealType == Enitities.Enums.MealType.Ogle).GroupBy(x => x.FoodInfoID).OrderBy(x => x.Count()).FirstOrDefault().ToList();
                    int deneme = (int)query.Select(x => x.FoodInfoID).FirstOrDefault();
                    var query2 = db.FoodInfos.Where(x => x.FoodInfoID == deneme).ToList();

                    dataGridView1.DataSource = query2;
                }
                else if (rjComboBox1.SelectedIndex == 2)
                {
                    var query = db.Meals.Where(x => x.UserDetailID == GelenID && x.MealType == Enitities.Enums.MealType.Aksam).GroupBy(x => x.FoodInfoID).OrderBy(x => x.Count()).FirstOrDefault().ToList();
                    int deneme = (int)query.Select(x => x.FoodInfoID).FirstOrDefault();
                    var query2 = db.FoodInfos.Where(x => x.FoodInfoID == deneme).ToList();

                    dataGridView1.DataSource = query2;
                }
                else if (rjComboBox1.SelectedIndex == 3)
                {
                    
                    var query = db.Meals.Where(x => x.UserDetailID == GelenID && x.MealType == Enitities.Enums.MealType.AraOgun).GroupBy(x => x.FoodInfoID).OrderBy(x => x.Count()).FirstOrDefault().ToList();
                    int deneme = (int)query.Select(x => x.FoodInfoID).FirstOrDefault();
                    var query2 = db.FoodInfos.Where(x => x.FoodInfoID == deneme).ToList();

                    dataGridView1.DataSource = query2;
                }
                else if (rjComboBox1.SelectedIndex == 4)
                {
                    var query = db.Meals.Where(x => x.UserDetailID == GelenID).GroupBy(x => x.FoodInfoID).OrderBy(x => x.Count()).FirstOrDefault().ToList();

                    int deneme = (int)query.Select(x => x.FoodInfoID).FirstOrDefault();
                    var query2 = db.FoodInfos.Where(x => x.FoodInfoID == deneme).ToList();

                    dataGridView1.DataSource = query2;
                }
 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Hatalı işlem !!!");
            }
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Hatalı işlem !!! ");
            }
            
        }


    }
}
