using DataAccessLayer.Context;
using Enitities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_Layerr
{
    public partial class frm_KullaniciBilgiGuncelle : Form
    {
        public int GelenID { get; set; }
        public frm_KullaniciBilgiGuncelle(int gelenID)
        {
            InitializeComponent();
            GelenID = gelenID;
        }
        Context db = new Context();


        private void rjButton1_Click_1(object sender, EventArgs e)
        {

            int say, say2;
            bool _suc = int.TryParse(textBox1.Text, out say);
            bool _suc1 = int.TryParse(textBox2.Text, out say2);

            if (_suc && _suc1 && rjDatePicker1.Value.Year < DateTime.Now.Year && textBox4.Text != "" && textBox3.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                frm_KayitDevam frm = new frm_KayitDevam();
                frm_KayitOl frm_KayitOl = new frm_KayitOl();
                // frm.AGK_HEsapla()
                var que = db.BodyAnalyses.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
                que.UserHeight = say;
                que.UserWeight = say2;
                var que2 = db.UserDetails.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
                que2.BirthDate = rjDatePicker1.Value;
                que.AGK = frm.AGK_HEsapla(say, say2, que2.gender, DateTime.Now.Year - que2.BirthDate.Year);
                que.VKE = frm_KayitOl.VKE_Hesapla(say, say2);
                var que3 = db.Users.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
                que3.UserName = textBox3.Text;
                que3.UserSurname = textBox4.Text;

                db.SaveChanges();
                MessageBox.Show("Güncelleme İşlemi Başarışı ;)");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.");
            }
        }

        private void frm_KullaniciBilgiGuncelle_Load_1(object sender, EventArgs e)
        {
            var BilgiGetir = db.BodyAnalyses.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
            textBox1.Text = BilgiGetir.UserHeight.ToString();
            textBox2.Text = BilgiGetir.UserWeight.ToString();
            var Bilgi2 = db.UserDetails.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
            rjDatePicker1.Value = Bilgi2.BirthDate.Date;
            var Bilgi3 = db.Users.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
            textBox3.Text = Bilgi3.UserName;
            textBox4.Text = Bilgi3.UserSurname;
        }
    }
}
