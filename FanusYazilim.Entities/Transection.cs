using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.Entities
{
    [Table("Transections")]
    public class Transection
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransectionID { get; set; }
        public DateTime Time { get; set; }
        public string ContentHead { get; set; }
        public string CategoryName { get; set; }
        public int Count { get; set; }

    }
}
