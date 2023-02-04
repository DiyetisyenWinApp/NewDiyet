using Enitities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserSurname { get; set; }
        [Required]
        [MaxLength(70)]
        public string E_Mail { get; set; }
        [Required]
        public string KullanıcıSifre { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public UserType userType { get; set; } = UserType.User;
        public string ImageURL { get; set; } = null;

        //Bağlantılar

        public virtual int? UserDetailID { get; set; }
        public UserDetail UserDetail { get; set; }




    }
}
