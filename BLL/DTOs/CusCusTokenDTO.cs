using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CusCusTokenDTO : CustomerDTO
    {
        public List<CusToken> CusTokens { get; set; }
        public CusCusTokenDTO()
        {
            CusTokens = new List<CusToken>();
        }
    }
}
