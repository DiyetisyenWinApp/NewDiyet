using DataAccessLayer.Context;
using Enitities.Enums;
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
        DateTime Bugün = DateTime.Now;
        private void frm_AnaMenü_Load(object sender, EventArgs e)
        {
            materialLabel2.Text = "Günlük Toplam Değerler";

            try
            {

                var query1 = db.Users.Where(x => x.UserID == GelenID).FirstOrDefault();
                rjTextBox5.Texts = "Merhaba " + query1.UserName.ToUpper() ;
                ProgresBarSet();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " Hata");
            }

            KahvaltiKaloriToplam();
            OgleYemegiKaloriToplam();
            AksamYemegiKaloriToplam();
        }
        private void AksamYemegiKaloriToplam()
        {
            float topAksamKalori = 0;
            var qry = db.BodyAnalyses.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
            var qry2 = db.Meals.Where(x => x.UserDetailID == GelenID && x.TüketimTarihi.Day == Bugün.Day && x.TüketimTarihi.Month == Bugün.Month && Bugün.Year == x.TüketimTarihi.Year && x.MealType == MealType.Aksam);

            foreach (var item in qry2)
            {
                topAksamKalori += item.TopKcall;
            }
            rjTextBox4.Texts = "Akşam Yemeğinde Toplam : " + topAksamKalori.ToString() + " Kalori Aldınız";
        }
        private void OgleYemegiKaloriToplam()
        {
            float topOgleKalori = 0;
            var qry = db.BodyAnalyses.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
            var qry2 = db.Meals.Where(x => x.UserDetailID == GelenID && x.TüketimTarihi.Day == Bugün.Day && x.TüketimTarihi.Month == Bugün.Month && Bugün.Year == x.TüketimTarihi.Year && x.MealType == MealType.Ogle);

            foreach (var item in qry2)
            {
                topOgleKalori += item.TopKcall;
            }
            rjTextBox3.Texts = "Öğle Yemeğinde Toplam : " + topOgleKalori.ToString() + " Kalori Aldınız";
        }
        private void KahvaltiKaloriToplam()
        {
            float topKahvaltı = 0;
            var qry = db.BodyAnalyses.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
            var qry2 = db.Meals.Where(x => x.UserDetailID == GelenID && x.TüketimTarihi.Day == Bugün.Day && x.TüketimTarihi.Month == Bugün.Month && Bugün.Year == x.TüketimTarihi.Year && x.MealType == MealType.Kahvaltı);

            foreach (var item in qry2)
            {
                topKahvaltı += item.TopKcall;
            }
            rjTextBox2.Texts = "Kahvaltıda Toplam : " + topKahvaltı.ToString() + " Kalori Aldınız";
        }

        private void ProgresBarSet()
        {
            
            float top = 0;
            var qry = db.BodyAnalyses.Where(x => x.UserDetailID == GelenID).FirstOrDefault();
            var qry2 = db.Meals.Where(x => x.UserDetailID == GelenID && x.TüketimTarihi.Day == Bugün.Day && x.TüketimTarihi.Month == Bugün.Month && Bugün.Year == x.TüketimTarihi.Year);

            foreach (var item in qry2)
            {
                top += item.TopKcall;
            }
            if ((int)qry.AGK >= (int)top)
            {
                progressBar1.Maximum = (int)qry.AGK;
                progressBar1.Value = (int)top;
                rjTextBox1.Texts = ((int)qry.AGK - (int)top).ToString() + " kalori değerinde besin tüketerek hedefinize ulaşın ";
            }
            else
            {
                progressBar1.Maximum = (int)qry.AGK;
                progressBar1.Value = (int)qry.AGK;
                rjTextBox1.Texts = "Günlük Hedef Aşıldı";
            }
        }

        private void btn_OgunEkle_Click(object sender, EventArgs e)
        {
            frm_Meal frm_Meal = new frm_Meal(GelenID);
            frm_Meal.Show();
            

        }

        private void btn_YemekEkle_Click(object sender, EventArgs e)
        {
            frm_YemekEkle frm_YemekEkle = new frm_YemekEkle();
            frm_YemekEkle.Show();
            
        }

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            frm_Rapor frm_Rapor = new frm_Rapor(GelenID);
            frm_Rapor.Show();
            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            KahvaltiKaloriToplam();
            OgleYemegiKaloriToplam();
            AksamYemegiKaloriToplam();
            ProgresBarSet();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            frm_Yiyecekler frmYiyecek = new frm_Yiyecekler();
            frmYiyecek.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            frm_KullaniciBilgiGuncelle frm = new frm_KullaniciBilgiGuncelle(GelenID);
            frm.Show();

        }
    }
}
