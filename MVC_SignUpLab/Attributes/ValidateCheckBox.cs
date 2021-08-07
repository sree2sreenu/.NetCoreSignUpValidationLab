using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SignUpLab.Attributes
{
    public class ValidateCheckBox: ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-validatechk", ErrorMessage);
        }

        public override bool IsValid(object value)
        {
            return (bool)value;
            //return base.IsValid(value);
        }
    }
}
