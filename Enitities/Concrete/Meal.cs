using Enitities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities.Concrete
{
    public class Meal
    {
        [Key]
        public int MealID { get; set; }
        public MealType MealType { get; set; }
        public float TopKcall { get; set; }
        public DateTime TüketimTarihi { get; set; }

        //bağlantılar
        public virtual int UserID { get; set; }
        public User User { get; set; }


        //public ICollection<FoodInfo> FoodInfos { get; set; }


    }
}
