using PracticeApp.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Please enter your name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter your desired username")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Please enter your desired password")]
        public String Password { get; set; }

        [Required(ErrorMessage = "Kindly retype the password")]
        [Compare("Password", ErrorMessage ="Confirm password doesn't match the password")]
        public String ConfirmPassword { get; set; }

        //[Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage ="Please enter correct contact no")]
        public String Contact { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        public String Country { get; set; }

        [Required(ErrorMessage = "Please select your city")]
        public String City { get; set; }

        [Required(ErrorMessage = "Please select your gender")]
        public String Gender{ get; set; }

        [ValidateCheckbox(ErrorMessage = "Please Accept Terms")]
        public bool Terms{ get; set; }
    }

}
