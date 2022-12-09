using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Wrong mobile")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Type { get; set; }
        public List<CusToken> CusTokens { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Payment> Payments { get; set; }
        public Customer()
        {
            CusTokens = new List<CusToken>();
            Bookings = new List<Booking>();
            Reviews = new List<Review>();
            Ratings = new List<Rating>();
            Payments = new List<Payment>();
        }
    }
}
