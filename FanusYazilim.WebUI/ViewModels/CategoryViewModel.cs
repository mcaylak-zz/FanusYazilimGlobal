using FanusYazilim.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FanusYazilim.WebUI.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        public string CategoryImageUrl { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
    }
}