using Enitities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities.Concrete
{
    public class User
    {
        
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string E_Mail { get; set; }
        public string KullanıcıSifre { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public UserType userType { get; set; } = UserType.User;




    }
}
