using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.Entities
{
    [Table("Contents")]
    public class Content
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContentID { get; set; }
        [StringLength(5000)]
        public string Description { get; set; }
        public string Head { get; set; }
        public int DisplayLength { get; set; }
        public int PrintLength { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
