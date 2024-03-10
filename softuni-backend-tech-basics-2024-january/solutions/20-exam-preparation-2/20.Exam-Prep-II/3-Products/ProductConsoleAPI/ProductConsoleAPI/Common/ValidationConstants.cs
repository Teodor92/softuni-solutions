using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsoleAPI.Common
{
    public class ValidationConstants
    {
        public const int ProductCodeMaxLength = 26;
        public const int ProductCodeMinLength = 5;
        public const int ProductNameLength = 40;
        public const int CountryNameLength = 60;
        public const int DescriptionLength = 255;
        public const string PriceMinValue = "0";
        public const string PriceMaxValue = "79228162514264337593543950334";
        public const int QuantityMinValue = 0;
    }
}
