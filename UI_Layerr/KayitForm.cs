﻿using DataAccessLayer.Context;
using Enitities.Concrete;
using Enitities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Layerr.Properties;

namespace UI_Layerr
{
    public partial class frm_KayitOl : Form 
    {
        public frm_KayitOl()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            cmb_boy.SelectedIndex = 0;
            cmb_kilo.SelectedIndex = 0;
            
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_GirisYap form1 = new frm_GirisYap();
            form1.Show();
        }

        private void btn_KayıtOl_Click(object sender, EventArgs e)
        {
            Context db = new Context();

            var kntrl = db.Users.Where(x => x.E_Mail == txt_ePosta.Text).Count();
            if (kntrl > 0)
            {
                MessageBox.Show("Bu kullanıcı adı kullanılmaktadır.");
            }
            else
            {

                if (txt_Ad.Text != "" && txt_ePosta.Text != "" && txt_Parola.Text != "" && txt_Soyad.Text != "" && dtp_DogumTarihi.Value.Year < DateTime.Now.Year )

                {
                    // İlgili Tablolara ve Methodalra Erişim
                    frm_GirisYap form1 = new frm_GirisYap();
                    User N_user = new User();                 
                    UserDetail N_userDetail = new UserDetail();
                    BodyAnalysis N_bdyAnaliz = new BodyAnalysis();

                    // kayıt formunda girilen değerler user tablosasuna eklendi
                    N_user.E_Mail = txt_ePosta.Text; 
                    N_user.UserName = txt_Ad.Text;
                    N_user.UserSurname = txt_Soyad.Text;
                    N_user.KullanıcıSifre = form1.ShaHash(txt_Parola.Text);
                                    //N_user.ImageURL = rjCircularPictureBox1 // url eklenecek



                    // User detail tablosuna dogum tarihi ve cinsiyet verileri eklendi
                    N_userDetail.BirthDate = dtp_DogumTarihi.Value.Date;
                    if (Rdo_Erkek.Text == "Erkek")
                    {
                        
                        N_userDetail.gender = Enitities.Enums.Gender.Erkek;
                    }
                    else
                    {
                        
                        
                        N_userDetail.gender = Enitities.Enums.Gender.Kadın;
                    }
                    

                    //kayıt formundaki bilgiler bodyAnliz tablosuna eklendi ve vke hesaplanarak eklendi
                    N_bdyAnaliz.UserWeight = cmb_kilo.SelectedIndex + 30;
                    N_bdyAnaliz.UserHeight = cmb_boy.SelectedIndex + 30;
                    N_bdyAnaliz.VKE = VKE_Hesapla((float)N_bdyAnaliz.UserHeight, (float)N_bdyAnaliz.UserWeight);


                    //userdetail tablsunda yapılan değişiklikler veri tabanına kayıt edildi
                    db.UserDetails.Add(N_userDetail);
                    db.SaveChanges();

                    //user detail tablosunda oluşan User detail ID user ve BodyANlaize eklenerek verilerin aynı kişiye ait olduğu doğrulandı
                    N_user.UserDetailID = N_userDetail.UserDetailID;
                    N_bdyAnaliz.UserDetailID = N_userDetail.UserDetailID;

                    //bodyAnaliz ve user tablsounda yapılan değişiklikler veri tabanına işlendi
                    db.BodyAnalyses.Add(N_bdyAnaliz);
                    db.SaveChanges();
                    db.Users.Add(N_user);
                    db.SaveChanges();

                    // form 2 ye gödnerilecek olan ID gönderildi ve AGK hesaplama için gerekli olan verielr forma iletildi.
                    frm_KayitDevam frmDevam = new frm_KayitDevam((int)N_userDetail.UserDetailID, (int)N_bdyAnaliz.UserHeight, (int)N_bdyAnaliz.UserWeight, N_userDetail.gender, (DateTime.Now.Year - N_userDetail.BirthDate.Year));
                    frmDevam.Show();
                    this.Hide();






                }
                else
                {
                    MessageBox.Show("Lutfen dogru degerler girin");
                }
                
                

            }



        }
       public float VKE_Hesapla(float boy, float kilo)
        {
            return kilo / ((boy / 100) * (boy / 100));
        }

        // formda bulunan text boxların tıklandığında boşalmsı için clik iventi kullanıldı
        private void txt_Ad_Click(object sender, EventArgs e)
        {
            txt_Ad.Text = "";
        }

        private void txt_Soyad_Click(object sender, EventArgs e)
        {
            txt_Soyad.Text = "";
        }

        private void txt_ePosta_Click(object sender, EventArgs e)
        {
            txt_ePosta.Text = "";
        }

        private void txt_Parola_Click(object sender, EventArgs e)
        {
            txt_Parola.Text = "";
        }

        private void btn_ResimEkle_Click(object sender, EventArgs e)
        {

        }

        private void Rdo_Erkek_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdo_Erkek.Checked)
            {
                rjCircularPictureBox1.Image = Resources.My_project;
            }
            
        }

        private void Rdo_Kadın_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdo_Kadın.Checked)
            {
                rjCircularPictureBox1.Image = Resources.istockphoto_1212576552_612x612;
                
            }
            
        }
    }
}
