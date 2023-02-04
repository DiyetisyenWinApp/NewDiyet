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
    public partial class frm_AnaMenü : Form
    {
        public frm_AnaMenü()
        {
            InitializeComponent();
        }
        int GelenID;
        public frm_AnaMenü(int ID)
        {
            InitializeComponent();
            GelenID = ID;
        }
        Context db = new Context();
        private void frm_AnaMenü_Load(object sender, EventArgs e)
        {
            var query1 = db.Users.Where(x => x.UserID == GelenID).FirstOrDefault();
            materialLabel1.Text = query1.UserName;
        }
    }
}
