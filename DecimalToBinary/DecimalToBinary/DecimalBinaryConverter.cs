using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToBinary
{
    class DecimalBinaryConverter
    {
        public string ConvertToBinary(long decimalNumber)
        {
            if (decimalNumber < 0)
            {
                throw new ArgumentException("Only positive decimal number expected!");
            }

            long quotient;
            long remainder;

            StringBuilder binaryBuilder = new StringBuilder();
            while (decimalNumber > 0)
            {
                quotient = decimalNumber / 2;
                remainder = decimalNumber % 2;
                decimalNumber = quotient;

                binaryBuilder.Append(remainder);
            }
            return string.Join("", binaryBuilder.ToString().ToCharArray().Reverse());
        }
    }
}
