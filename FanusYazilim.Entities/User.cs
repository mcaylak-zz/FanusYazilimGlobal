using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FanusYazilim.Entities
{
    [Table("Users")]
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [StringLength(72)]
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid SecurityGuid { get; set; }
    }
}


