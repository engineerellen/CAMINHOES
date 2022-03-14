using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Domain.Validator
{
     public class AnoFabricacaoValidatorAttribute : ValidationAttribute
    {


        public AnoFabricacaoValidatorAttribute()
            : base("{0} não é o ano atual!")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int val = Convert.ToInt32(value);

            bool valid = val.Equals(DateTime.Now.Year);

            if (valid)
                return null;

            return new ValidationResult(base.FormatErrorMessage(validationContext.MemberName)
                , new string[] { validationContext.MemberName });
        }
    }

}


