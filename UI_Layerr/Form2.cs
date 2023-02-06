using DataAccessLayer.Context;
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
    public partial class frm_Yiyecekler : Form
    {
        public frm_Yiyecekler()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void frm_Yiyecekler_Load(object sender, EventArgs e)
        {
            label2.Text = "Lezzetli Görünüyorlar. \n\r Hadi aradığını bulalım";
            label3.Text = "Toplam Yiyecek Miktarı " + db.FoodInfos.Count();
            dataGridView1.DataSource = db.FoodInfos.ToList();
            dataGridView1.Columns[7].Visible = false;
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            string InputText = rjTextBox1.Texts;
            var query = db.FoodInfos.Where(x => x.FoodName.Contains(InputText)).ToList();
            int query2 = db.FoodInfos.Where(x => x.FoodName.Contains(InputText)).Count();
            if (query2 == 0)
            {
                label2.Text = "Tüh " + InputText + " Bizde Yok. \n\r Yemek Ekle Menüsünden Ekleyebilirsin";
            }
            else
            {
                label2.Text = "Bunları buldum eğer aradığın yoksa \n\r Farklı bir söz dizimi dene";
            }

            dataGridView1.DataSource = query;
            dataGridView1.Columns[7].Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
