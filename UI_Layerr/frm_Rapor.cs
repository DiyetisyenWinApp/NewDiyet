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
    public partial class frm_Rapor : Form
    {
        Context db = new Context();
        public frm_Rapor()
        {
            InitializeComponent();
        }
        public int glnID;
        public frm_Rapor(int gelen)
        {
            InitializeComponent();
            glnID = gelen;



        }
        private void frm_Rapor_Load(object sender, EventArgs e)
        {
            rjComboBox1.Items.Add("Kahvaltıda en çok yediklerim");
            rjComboBox1.Items.Add("Öğle yemeğinde en çok yediklerim");
            rjComboBox1.Items.Add("Akşam yemeğinde en çok yediklerim");
            rjComboBox1.Items.Add("Ara Öğünlerde en çok yediklerim");
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var query = db.Meals.Where(x => x.UserDetailID == glnID && x.TüketimTarihi.Date == rjDatePicker1.Value.Date);
                dataGridView1.DataSource = query.ToList();
                var que = db.Meals.Where(x => x.UserDetailID == glnID).Sum(x => x.TopKcall);
                label1.Text = que.ToString();
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
