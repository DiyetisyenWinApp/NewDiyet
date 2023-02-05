using DataAccessLayer.Context;
using Enitities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            var queryYemekelr = db.FoodInfos.Where(x => x.FoodName == yemekAdı);
            dataGridView1.DataSource = queryYemekelr.ToList();
            foreach (var item in queryYemekelr)
            {

                lbx_Yemekler.Text = item.ToString();
            }
        }
    }
}
