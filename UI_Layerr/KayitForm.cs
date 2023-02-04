using DataAccessLayer.Context;
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

namespace UI_Layerr
{
    public partial class KayitForm : Form 
    {
        public KayitForm()
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
            Form1 form1 = new Form1();
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
                    // İlgili Tablolara Erişim
                    
                    Form1 form1 = new Form1();
                    User N_user = new User();                 
                    UserDetail N_userDetail = new UserDetail();
                    BodyAnalysis N_bdyAnaliz = new BodyAnalysis();

                    // user tablosunda ilgili veriler
                    N_user.E_Mail = txt_ePosta.Text; 
                    N_user.UserName = txt_Ad.Text;
                    N_user.UserSurname = txt_Soyad.Text;
                    N_user.KullanıcıSifre = form1.ShaHash(txt_Parola.Text);
                    N_user.UserDetailID = N_userDetail.UserDetailID;
                    //N_user.ImageURL = rjCircularPictureBox1 // url eklenecek





                    // User detail dogum tarihi
                    N_userDetail.BirthDate = dtp_DogumTarihi.Value;
                    if (Rdo_Erkek.Text == "Erkek")
                    {

                        N_userDetail.gender = Enitities.Enums.Gender.Erkek;
                    }
                    else
                    {
                        N_userDetail.gender = Enitities.Enums.Gender.Kadın;
                    }
                    N_userDetail.BirthDate = dtp_DogumTarihi.Value.Date;

                    N_bdyAnaliz.UserWeight = cmb_kilo.SelectedIndex + 30;
                    N_bdyAnaliz.UserHeight = cmb_boy.SelectedIndex + 30;
                    N_bdyAnaliz.UserDetailID = N_userDetail.UserDetailID;
                    N_bdyAnaliz.VKE = VKE_Hesapla((float)N_bdyAnaliz.UserHeight, (float)N_bdyAnaliz.UserWeight);

                    // form 2 ye gödnerilecek olan ID
                    KayitDevamForm frmDevam = new KayitDevamForm((int)N_user.UserDetailID, (int)N_bdyAnaliz.UserHeight, (int)N_bdyAnaliz.UserWeight, N_userDetail.gender, (DateTime.Now.Year - N_userDetail.BirthDate.Year));
                    frmDevam.Show();
                    this.Hide();



                    db.UserDetails.Add(N_userDetail);
                    db.SaveChanges();
                    db.BodyAnalyses.Add(N_bdyAnaliz);
                    db.SaveChanges();
                    db.Users.Add(N_user);
                    db.SaveChanges();


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














    }
}
