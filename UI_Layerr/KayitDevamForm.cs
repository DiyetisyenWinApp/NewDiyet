using DataAccessLayer.Context;
using Enitities.Concrete;
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
    public partial class KayitDevamForm : Form
    {
        Context db = new Context();
        public KayitDevamForm()
        {
            InitializeComponent();


        }
        public int gelenUserDetailID;
        public int gelenBoy;
        public int gelenKilo;
        public Gender gelenGender;
        public int gelenYas;

        public KayitDevamForm(int ID, int boy, int kilo,Gender gender, int yas)
        {

            InitializeComponent();
            gelenUserDetailID = ID;
            gelenBoy = boy;
            gelenKilo = kilo;
            gelenGender = gender;
            gelenYas = yas;
         
        }
        public float hareket;
        public float hedef;
        
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            // activity level seçim
            
            var query_UserDetail1 = db.UserDetails.Where(x => x.UserDetailID == gelenUserDetailID).FirstOrDefault();
            if (cmb_Aktivite.SelectedIndex == 0)
            {
                query_UserDetail1.acitvityLevel = Enitities.Enums.AcitvityLevel.Non;
                hareket = 1;

            }
            else if(cmb_Aktivite.SelectedIndex == 1)
            {
                query_UserDetail1.acitvityLevel = Enitities.Enums.AcitvityLevel.Easy;
                hareket = 1.2F;
            }
            else if (cmb_Aktivite.SelectedIndex == 2)
            {
                query_UserDetail1.acitvityLevel = Enitities.Enums.AcitvityLevel.Middle;
                hareket = 1.375F;
            }
            else if (cmb_Aktivite.SelectedIndex == 3)
            {
                query_UserDetail1.acitvityLevel = Enitities.Enums.AcitvityLevel.Hard;
                hareket = 1.55F;
            }
            else if (cmb_Aktivite.SelectedIndex == 4)
            {
                query_UserDetail1.acitvityLevel = Enitities.Enums.AcitvityLevel.Extreme;
                hareket = 1.80F;
            }

            
            // Hedef seçim veri tabanın aklayıt

            var query_UserDetail = db.UserDetails.Where(x => x.UserDetailID == gelenUserDetailID).FirstOrDefault();
            if(cmb_HedefSecim.SelectedIndex == 0)
            {
                query_UserDetail1.intention = Enitities.Enums.Intention.WeightLose;
                hedef = -500;
            }
            else if(cmb_HedefSecim.SelectedIndex == 1)
            {
                query_UserDetail1.intention = Enitities.Enums.Intention.KeepWeight;
                hedef = 0;
            }
            else if (cmb_HedefSecim.SelectedIndex == 2)
            {
                query_UserDetail1.intention = Enitities.Enums.Intention.WeightGain;
                hedef = 500;
            }

            var query_bodyAnalys = db.BodyAnalyses.Where(x => x.UserDetailID == gelenUserDetailID).FirstOrDefault();
            query_bodyAnalys.AGK = AGK_HEsapla(gelenBoy, gelenKilo, gelenGender, gelenYas);

            db.SaveChanges();
            


        }


        public float AGK_HEsapla(int boy, int kilo, Gender gender, int yas)
        {
            float bazalMetobolizma;
            if (gender == Gender.Erkek)
            {
                bazalMetobolizma = 66.5F + (13.75F * kilo) + (5 * (boy / 100) - (6.77F * yas));
            }
            else
            {
                bazalMetobolizma = 655.1F + (9.56F * kilo) + (1.85F * (boy / 100) - (4.67F * yas));
            }
            return (bazalMetobolizma * hareket) + hedef;
        }

        private void KayitDevamForm_Load(object sender, EventArgs e)
        {
            // aktivite combo Box maddeler
            cmb_Aktivite.Items.Add("Çok Az Hareketli (Hareket etmiyorum veya çok az hareket ediyorum.)");
            cmb_Aktivite.Items.Add("Az hareketli (Hafif hareketli bir yaşam / Haftada 1-3 gün egzersiz yapıyorum.)");
            cmb_Aktivite.Items.Add("Orta derece hareketli (Hareketli bir yaşam / Haftada 3-5 gün egzersiz yapıyorum.)");
            cmb_Aktivite.Items.Add("Çok hareketli (Çok hareketli bir yaşam / Haftada 6-7 gün egzersiz yapıyorum.)");
            cmb_Aktivite.Items.Add("Aşırı hareketli (Profesyonel sporcu, atlet seviyesi.)");

            //Hedef Combbo box Maddeler

            cmb_HedefSecim.Items.Add("Zayıflamak, yağ yakmak.");
            cmb_HedefSecim.Items.Add("Kilomu korumak");
            cmb_HedefSecim.Items.Add("Kilo Almak.");

        }
    }
}
