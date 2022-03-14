using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Domain.Validator
{
    public class AnoModeloValidatorAttribute : ValidationAttribute
    {


        public AnoModeloValidatorAttribute()
            : base("{0} não é o ano atual ou o próximo!")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int val = Convert.ToInt32(value);

            bool valid = val.Equals(DateTime.Now.Year)|| val.Equals(DateTime.Now.Year + 1);

            if (valid)
                return null;

            return new ValidationResult(base.FormatErrorMessage(validationContext.MemberName)
                , new string[] { validationContext.MemberName });
        }
    }

}
