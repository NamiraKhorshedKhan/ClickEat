using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CusBookingsDTO
    {
        public int Id { get; set; }
        public int CusID { get; set; }
        public int ResID { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public RestaurantDTO RestaurantDTO { get; set; }
        public CustomerDTO CustomerDTO { get; set; }
    }
}
