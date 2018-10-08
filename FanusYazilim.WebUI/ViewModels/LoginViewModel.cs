using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FanusYazilim.WebUI.ViewModels
{
    public class LoginViewModel
    {
        [StringLength(72),Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [StringLength(72),Required]
        public string Email { get; set; }
    }

    public class NewPasswordViewModel
    {
        [StringLength(72),Required]
        public string Password { get; set; }
    }
}