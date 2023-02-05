using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities.Concrete
{
    public class FoodInfo
    {
        [Key]
        public int FoodInfoID { get; set; }
        [Required]
        [MaxLength (50)]
        public string FoodName { get; set; }
        [Required]
        public float Gram { get; set; }
        [Required]
        public float Kalori { get; set; }
        [Required]
        public float Karbonhidrat { get; set; }
        [Required]
        public float Protein { get; set; }
        [Required]
        public float Yag { get; set; }

        public ICollection<Meal> Meal { get; set; }


    }
}
