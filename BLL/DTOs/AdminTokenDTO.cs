using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminTokenDTO
    {
        public int Id { get; set; }
        public int Tkey { get; set; }
        public System.DateTime Creation { get; set; }
        public Nullable<System.DateTime> Expiration { get; set; }
        public int AdminID { get; set; }
    }
}
