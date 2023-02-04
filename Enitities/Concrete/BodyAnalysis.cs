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
        public float? VKE { get; set; }
        public float? AGK { get; set; }
        
        public int? UserHeight { get; set; }
        
        public int? UserWeight { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        //Bağlantılar
        [Required]
        public virtual int UserDetailID { get; set; }
        public UserDetail UserDetail { get; set; }

    }



}
