using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanusYazilim.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        public int DisplayLength { get; set; }
        public string CategoryImageUrl { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
    }
}
