using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminAdminTokenDTO: AdminDTO
    {
        public List<AdminToken> AdminTokens { get; set; }
        public AdminAdminTokenDTO()
        {
            AdminTokens = new List<AdminToken>();
        }
    }
}
