using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace gestion_de_stocks
{
    class TestValidation : ValidationRule
    {
        public TestValidation()
        { }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is not string inputValue)
                return new ValidationResult(false, "Veuillez entrer une chaîne de caractères.");

            if (inputValue.Length >= 10)
                return new ValidationResult(false, "La longueur de la chaîne doit être inférieure à 10 caractères.");

            return ValidationResult.ValidResult;
        }
    }
}
