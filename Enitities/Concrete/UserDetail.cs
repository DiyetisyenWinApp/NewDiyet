using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitities.Enums;

namespace Enitities.Concrete
{
    public class UserDetail
    {
        [Key]
        public int UserDetailID { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public Gender gender { get; set; }
        
        public AcitvityLevel? acitvityLevel { get; set; } 
        
        public Intention? intention { get; set; }

        //Bağlantılar
        //public virtual int? UserID { get; set; }
        //public User User { get; set; }


        public ICollection<BodyAnalysis> BodyAnalyses { get; set; }



    }
}
