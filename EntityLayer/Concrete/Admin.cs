using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(20)]
        public string Username { get; set; }
        [StringLength(1)]
        public string AdminRole { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
    }
}
