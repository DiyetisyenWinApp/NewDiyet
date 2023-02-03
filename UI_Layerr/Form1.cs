﻿using DataAccessLayer.Context;
using Enitities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layerr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void txt_ePosta_Click(object sender, EventArgs e)
        {
            txt_ePosta.Text = "";

        }

        private void txt_Parola_Click(object sender, EventArgs e)
        {
            txt_Parola.Text = "";
        }
        public int BulunanID;
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            
            Context db = new Context();
            var query = db.Users.Where(x => x.E_Mail == txt_ePosta.Text && x.KullanıcıSifre == ShaHash(txt_Parola.Text)).FirstOrDefault();

            

            if (query.UserID == null)
            {
                MessageBox.Show("Hatalı şifre veya e_posta");
            }
            else
            {
                BulunanID = query.UserID;
                Form2 frm2 = new Form2(BulunanID);
                frm2.Show();
                this.Hide();
                // form2 ye bulunan kullanıcının ID si gönderilecek
            }

            
            
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }


        //Methodlar
        public string ShaHash(string parola)
        {
            SHA256 sHA256 = SHA256.Create();

            byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(parola));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString());
            }
            return sb.ToString();
        }

        //private void btnYeniKullanici_Click(object sender, EventArgs e)
        //{
        //    Form2 form2 = new Form2();
        //    form2.ShowDialog();
        //}

        //private void btnGiris_Click(object sender, EventArgs e)
        //{
        //    Model1 db = new Model1();
        //    string pass = ShaHash(txtSifre.Text);
        //    var UserBul = db.Users.Where(x => x.UserName == txtKullaniciAdi.Text && x.Password == pass).Count();
        //    if (UserBul > 0)
        //    {
        //        Form3 form3 = new Form3();

        //        form3.ShowDialog();

        //    }
        //    else
        //    {
        //        MessageBox.Show("Hatalı giriş");
        //    }
        //}
    }
}
