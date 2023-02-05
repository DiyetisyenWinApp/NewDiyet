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
    public partial class frm_YemekEkle : Form
    {
        Context db = new Context();

        public frm_YemekEkle()
        {
            InitializeComponent();
        }
     

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FoodInfo foodInfo = new FoodInfo();
                foodInfo.FoodName = rjTextBox1.Texts;
                foodInfo.Kalori = (int)numericUpDown1.Value;
                foodInfo.Karbonhidrat = (int)numericUpDown2.Value;
                foodInfo.Protein = (int)numericUpDown3.Value;
                foodInfo.Yag = (int)numericUpDown4.Value;
                foodInfo.Gram = 100;
                db.FoodInfos.Add(foodInfo);
                db.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                rjTextBox1.Texts = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message +"Hatalı işlem !!!");
            }
           
        }
    }
}
