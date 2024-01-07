using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace gestion_de_stocks.Validation
{
    class IsString : ValidationRule
    {
        public IsString()
        { }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
         

            
            if (value is not string)
                return new ValidationResult(false, $"Please enter a string.");
           
            return ValidationResult.ValidResult;
        }
    }
}
