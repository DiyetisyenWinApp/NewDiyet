﻿using DataAccessLayer.Context;
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
            //var query1 = db.Users.Where(x => x.UserID == GelenID).FirstOrDefault();
            //materialLabel1.Text = query1.UserName;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            frm_Rapor frm_Rapor = new frm_Rapor();
            frm_Rapor.Show();
            this.Hide();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            frm_YemekEkle frm_YemekEkle = new frm_YemekEkle();
            frm_YemekEkle.Show();
            this.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            frm_Meal frm_Meal = new frm_Meal();
            frm_Meal.Show();
            this.Hide();

        }
    }
}
