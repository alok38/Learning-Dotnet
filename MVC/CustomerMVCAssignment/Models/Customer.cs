using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerMVCAssignment.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        [FirstNameValidation]
        public string FirstName { get; set; }

        [StringLength(10, ErrorMessage = "Last Name length should not be greater than 10")]
        public string LastName { get; set; }

        [Range(13,100,ErrorMessage ="Please Enter Valid Age only people above 13 can Enter")]
        public int Age { get; set; }

    }
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("please provide First Name");
            } //checking for empty value
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name Should not coontain @");
                }
            }
            return ValidationResult.Success;
        }
    }
}