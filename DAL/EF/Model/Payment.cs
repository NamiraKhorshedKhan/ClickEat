using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CusID { get; set; }
        [ForeignKey("Restaurant")]
        public int ResID { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Status { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
