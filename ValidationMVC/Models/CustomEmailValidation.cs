using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidationMVC.Helper;

namespace ValidationMVC.Models
{
    public class CustomEmailValidation:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var myData = Database.Emails.Contains(value);
                return !myData;
            }
            return true;
        }
    }
}