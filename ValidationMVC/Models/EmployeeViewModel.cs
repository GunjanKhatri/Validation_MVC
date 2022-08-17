using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationMVC.Models
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage ="Please enter first name")]
        [Display(Name ="First Name")]
        [MaxLength(12,ErrorMessage ="Please enter valid string")]
        [MinLength(3, ErrorMessage = "Please enter valid string")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last Name")]
        [MaxLength(12, ErrorMessage = "Please enter valid string")]
        [MinLength(3, ErrorMessage = "Please enter valid string")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter the salary")]
        [Range(2000,30000,ErrorMessage ="Please enter a valid salary")]
        public int Salary { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid EmailId")]
        [CustomEmailValidation(ErrorMessage ="Email Id already exists")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter the phone number")]
        [MaxLength(10,ErrorMessage ="Invalid number")]
        [MinLength(10,ErrorMessage = "Invalid number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Compare("Password",ErrorMessage ="Doesnot match Password")]
        public string ConfirmPassword { get; set; }
    }
}