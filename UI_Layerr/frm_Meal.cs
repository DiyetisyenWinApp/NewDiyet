using DataAccessLayer.Context;
using Enitities.Concrete;
using Enitities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_Layerr
{
    public partial class frm_Meal : Form
    {
        Context db = new Context();
        public frm_Meal()
        {
            InitializeComponent();
        }
        int GelenID ;
        public frm_Meal(int ID)
        {
            InitializeComponent();
            GelenID = ID;
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Meal_Load(object sender, EventArgs e)
        {
            cmb_Ogun.Items.Add(MealType.Kahvaltı);
            cmb_Ogun.Items.Add(MealType.Ogle);
            cmb_Ogun.Items.Add(MealType.Aksam);
            cmb_Ogun.Items.Add(MealType.AraOgun);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string yemekAdı = textBox1.Text;
            var queryYemekelr = db.FoodInfos.Where(x => x.FoodName.Contains(yemekAdı));
            dataGridView1.DataSource = queryYemekelr.ToList();


        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            string yemekAdı = textBox1.Text;
            var queryYemekelr = db.FoodInfos.Where(x => x.FoodName.Contains(yemekAdı)).FirstOrDefault();
            Meal meal = new Meal();
            if (comboBox1.SelectedIndex >= 0 && cmb_Ogun.SelectedIndex >= 0 && textBox1.Text != "")
            {
                meal.TüketimTarihi = DateTime.Now;
                meal.UserDetailID = GelenID;
                meal.TopKcall = (comboBox1.SelectedIndex) * queryYemekelr.Kalori;
                meal.MealType =
                    (cmb_Ogun.SelectedIndex == 0 ? MealType.Kahvaltı :
                    cmb_Ogun.SelectedIndex == 1 ? MealType.Ogle :
                    cmb_Ogun.SelectedIndex == 2 ? MealType.Aksam :
                    MealType.AraOgun);

                meal.FoodInfoID = queryYemekelr.FoodInfoID;
                db.Meals.Add(meal);
                db.SaveChanges();
                MessageBox.Show("başarılı bir şekilde kaydedildi ;)");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen tüm değeri giriniz");
            }
            


            //kuyllanıcı ıd ile alakalı ve o güne ait öğünleri bize getiriyor
            DateTime Bugün = DateTime.Now;
            var qry = db.Meals.Where(x => x.UserDetailID == GelenID && x.TüketimTarihi.Day == Bugün.Day && x.TüketimTarihi.Month == Bugün.Month && Bugün.Year == x.TüketimTarihi.Year).ToList();
            
            
            
                
            
                

            



            //List<IQueryable< FoodInfo>> a = new List<IQueryable< FoodInfo>>();








            //var qryFoodInfo = db.FoodInfos.Where(x => x.FoodInfoID == qry.FoodInfoID);
            //  dataGridView2.DataSource = qryFoodInfo.Select(x => new
            //    {
            //        YemekAdı = x.FoodName,
            //        Kalorı = x.Kalori
            //    }).ToList();

            //List<FoodInfo> list = new List<FoodInfo>();
            //List<string> lists = new List<string>();
            //foreach (var item in qry)
            //{
            //    var qry2 = db.FoodInfos.Where(x => x.FoodInfoID == item.FoodInfoID).FirstOrDefault();
            //    string a = qry2.FoodName.ToString();
            //    lists.Add(a);
            //}


            //dataGridView2.DataSource = lists;







        }
    }
}
