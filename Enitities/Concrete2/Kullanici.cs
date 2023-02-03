using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici 
    {
     

        //public int ID { get; set; }
        //public string KullaniciAdi { get; set; }
        //public string KullaniciSoyadi { get; set; }
        //public string Mail { get; set; }
        //public string KullaniciSifre { get; set; }
        public List<TuketilenBesin> TuketilenBesinler { get; set; }

        public virtual int? VucutAnaliziID { get; set; }
        public VucutAnalizi VucutAnalizi { get; set; }




        //public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }

     

  


        
    }
}
