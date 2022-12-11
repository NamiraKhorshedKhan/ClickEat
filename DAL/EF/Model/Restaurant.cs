using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Restaurant
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
        public string Address { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Invalid mobile number.")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Type { get; set; }
        public virtual List<ResToken> ResTokens { get; set; }
        public virtual List<Menu> Menus { get; set; }
        public virtual List<Booking> Bookings { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Rating> Ratings { get; set; }
        public virtual List<Payment> Payments { get; set; }
        public Restaurant()
        {
            ResTokens = new List<ResToken>();
            Menus = new List<Menu>();
            Bookings = new List<Booking>();
            Reviews = new List<Review>();
            Ratings = new List<Rating>();
            Payments = new List<Payment>();
        }
    }
}
