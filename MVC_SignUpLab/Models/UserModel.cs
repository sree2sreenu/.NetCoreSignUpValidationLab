using MVC_SignUpLab.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SignUpLab.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Please enter Name")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Please enter Username")]
        [EmailAddress(ErrorMessage ="Plase enter valid email address")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter Confirm Password")]
        [Compare("Password",ErrorMessage ="Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter Contact Number")]
        [RegularExpression("^[6789]\\d{9}",ErrorMessage ="Please enter valid contact number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please select Country")]
        [DisplayName("Country")]
        public string CountryCode { get; set; }

        public CountryModel Country { get; set; }

        [Required(ErrorMessage = "Please select City")]
        [DisplayName("City")]

        public string CityCode { get; set; }
        public CityModel City { get; set; }

        [Required(ErrorMessage = "Please select Gender")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please select Tearms.")]
        public bool Terms { get; set; }

    }
}
