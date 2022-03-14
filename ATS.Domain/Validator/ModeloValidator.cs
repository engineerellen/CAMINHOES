using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Domain.Validator
{
    public class ModeloValidatorAttribute : ValidationAttribute
    {


        public ModeloValidatorAttribute()
            : base("{0} Deverá ser FH ou FM")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string val = Convert.ToString(value);

            bool valid = val.Equals("FH") || val.Equals("FM");

            if (valid)
                return null;

            return new ValidationResult(base.FormatErrorMessage(validationContext.MemberName)
                , new string[] { validationContext.MemberName });
        }
    }

}
