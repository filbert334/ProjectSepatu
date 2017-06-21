using ProjectSepatu.Core.ProductProperties.CustomerClass;
using ProjectSepatu.Core.ProductProperties.KabupatenMasterClass;
using ProjectSepatu.Core.ProductProperties.KecamatanMasterClass;
using ProjectSepatu.Core.ProductProperties.ProvinsiMasterClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.LoginViewModel
{
    public class LoginViewModel
    {

    }
    public class RegisterViewModelNew
    {
        [Required, MaxLength(256)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }



    }
    public class LoginViewModelNew
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }

    }
}
