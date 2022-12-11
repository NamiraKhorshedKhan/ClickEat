using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ResMenuDTO
    {
        public int Id { get; set; }
        public int ResID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public RestaurantDTO RestaurantDTO { get; set; }
    }
}
