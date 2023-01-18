using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCDataLayerStart.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="Enter First Name")]
        [FirstNameValidation]
        public string FirstName { get; set; }

        [StringLength(10,ErrorMessage ="Last Name length should not be greater than 10")]
        public string LastName { get; set; }
        [Range(10000, 30000)]
        public int ?Salary { get; set; }
    }
    //custom validator
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
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