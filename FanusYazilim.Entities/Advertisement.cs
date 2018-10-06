using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.Entities
{
    [Table("Advertisements")]
    public class Advertisement
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdvertisementID { get; set; }
        [StringLength(100)]
        public string ImagePath { get; set; }
        [StringLength(72)]
        public string Owner { get; set; }
    }
}
