using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Restaurant")]
        public int ResID { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Type { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
