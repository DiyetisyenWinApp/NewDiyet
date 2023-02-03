using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitities.Enums;

namespace Enitities.Concrete
{
    public class UserDetail
    {
        public int UserDetailID { get; set; }
        public int UserHeight { get; set; }
        public int UserWeight { get; set; }
        public AcitvityLevel acitvityLevel { get; set; }
        public Gender gender { get; set; }


    }
}
