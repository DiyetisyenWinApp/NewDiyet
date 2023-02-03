using DataAccessLayer.Context;
using Enitities.Concrete;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
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

                if (txt_Ad.Text != "" && txt_ePosta.Text != "" && txt_Parola.Text != "" && txt_Soyad.Text != "" && dtp_DogumTarihi.Value.Year < DateTime.Now.Year)

                {
                    User N_user = new User();
                    N_user.E_Mail = txt_ePosta.Text;
                    N_user.UserName = txt_Ad.Text;
                    N_user.UserSurname = txt_Parola.Text;
                    UserDetail userDetail = new UserDetail();
                    userDetail.BirthDate = dtp_DogumTarihi.Value;

                    if (Rdo_Erkek.Text == "Erkek")
                    {

                        userDetail.gender = Enitities.Enums.Gender.Erkek;
                    }
                    else
                    {
                        userDetail.gender = Enitities.Enums.Gender.Kadın;
                    }
                    //userDetail. cmb_kilo.Text
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lutfen dogru degerler girin");
                }

            }

        }
        //            if (kntrl>0)
        //            {
        //                MessageBox.Show("Lütfen Farklı kullanıcı giriniz.");
        //            }
        //            else
        //            {

        //                if (label4.BackColor == Color.Green && label5.BackColor == Color.Green && txtSifre.Text == txtSifreTekrar.Text)
        //                {
        //                    string Pass = ShaHash(txtSifreTekrar.Text);
        //    User userK = new User();
        //    userK.UserName = txtKullaniciAdi.Text;
        //                    userK.Password = Pass;
        //                    db.Users.Add(userK);
        //                    db.SaveChanges();
        //                    MessageBox.Show("Yeni kullanıcı Oluşturuldu.");
        //                }
        //                else
        //   {
        //    MessageBox.Show("Lütfen şifrelerinizi aynı giriniz.");
        //   }
        //            }










    }
}
