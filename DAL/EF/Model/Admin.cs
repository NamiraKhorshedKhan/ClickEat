using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Admin
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
        public string Type { get; set; }
        public virtual List<AdminToken> AdminTokens { get; set; }
        public Admin()
        {
            AdminTokens = new List<AdminToken>();
        }
    }
}
