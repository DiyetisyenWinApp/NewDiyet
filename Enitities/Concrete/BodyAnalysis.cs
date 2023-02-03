using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities.Concrete
{
    public class BodyAnalysis
    {
        [Key]
        public int BodyAnalysisID { get; set; }
        public int VKE { get; set; }
        public int AGK { get; set; }
        [Required]
        public int UserHeight { get; set; }
        [Required]
        public int UserWeight { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        //Bağlantılar
        public virtual int UserDetailID { get; set; }
        public UserDetail UserDetail { get; set; }





    }

}
