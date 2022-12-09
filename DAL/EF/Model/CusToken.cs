using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class CusToken
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public int Tkey { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public DateTime Creation { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public DateTime Expiration { get; set; }
        [ForeignKey("Customer")]
        public int ResID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
