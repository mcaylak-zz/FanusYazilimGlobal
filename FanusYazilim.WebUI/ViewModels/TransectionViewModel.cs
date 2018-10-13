using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FanusYazilim.WebUI.ViewModels
{
    public class TransectionViewModel
    {
      
        public int TransectionID { get; set; }
        public DateTime Time { get; set; }
        public string ContentHead { get; set; }
        public string CategoryName { get; set; }

        public int Count { get; set; }
    }
}