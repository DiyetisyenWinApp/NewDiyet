﻿using System;
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
        public frm_YemekEkle()
        {
            InitializeComponent();
        }
        int GelenID;
        public frm_YemekEkle(int ID)
        {
            InitializeComponent();
            GelenID = ID;
        }
    }
}