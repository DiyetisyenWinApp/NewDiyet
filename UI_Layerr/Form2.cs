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

        private void frm_Yiyecekler_Load(object sender, EventArgs e)
        {
            Context db = new Context();
            dataGridView1.DataSource = db.FoodInfos.ToList();
            dataGridView1.Columns[7].Visible = false;
        }
    }
}
