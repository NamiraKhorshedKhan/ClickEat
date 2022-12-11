using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ResResTokenDTO : RestaurantDTO
    {
        public List<ResToken> ResTokens { get; set; }
        public ResResTokenDTO()
        {
            ResTokens = new List<ResToken>();
        }
    }
}
