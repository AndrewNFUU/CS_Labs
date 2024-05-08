using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab11_strings
{
    internal class DecimalString : SimpleString
    {
        public DecimalString() : base("0") { }

        public DecimalString(int number)
        {
            Str = number.ToString();
        }

        public DecimalString(string number)
        {
            /* pattern: ^ - start of string, may contain + or -,
               \d - set as much as u want numbers, $ - end of string */

            string stringFormat = @"^[+-]?\d+$"; // regular expression

            if (Regex.IsMatch(number, stringFormat))
            {
                Str = number.ToString();
            }
            else
            {
                throw new Exception("Incorrect input.  ");
            }
        }

        #region arithmetic_operations

        public DecimalString Add(DecimalString other)
        {
            decimal num1;
            decimal num2;

            if (!decimal.TryParse(this.Str, out num1))
            {
                throw new FormatException("Invalid format of first number.");
            }

            if (!decimal.TryParse(other.Str, out num2))
            {
                throw new FormatException("Invalid format of second number.");
            }

            decimal result = num1 + num2;

            if (result > decimal.MaxValue || result < decimal.MinValue)
            {
                throw new OverflowException("Result is out of limits.");
            }

            return new DecimalString(result.ToString());
        }

        public DecimalString Subtract(DecimalString other)
        {
            decimal num1;
            decimal num2;

            if (!decimal.TryParse(this.Str, out num1))
            {
                throw new FormatException("Invalid format of first number");
            }

            if (!decimal.TryParse(other.Str, out num2))
            {
                throw new FormatException("Invalid format of second number");
            }

            decimal result = num1 - num2;

            if (result > decimal.MaxValue || result < decimal.MinValue)
            {
                throw new OverflowException("Result is out of limits.");
            }

            return new DecimalString(result.ToString());
        }

        public DecimalString Multiplication(DecimalString other)
        {
            decimal num1;
            decimal num2;

            if (!decimal.TryParse(this.Str, out num1))
            {
                throw new FormatException("Invalid format of first number");
            }

            if (!decimal.TryParse(other.Str, out num2))
            {
                throw new FormatException("Invalid format of second number");
            }

            decimal result = num1 * num2;

            if (result > decimal.MaxValue || result < decimal.MinValue)
            {
                throw new OverflowException("Result is out of limits.");
            }

            return new DecimalString(result.ToString());
        }

        public DecimalString Division(DecimalString other)
        {
            decimal num1;
            decimal num2;

            if (!decimal.TryParse(this.Str, out num1))
            {
                throw new FormatException("Invalid format of first number");
            }

            if (!decimal.TryParse(other.Str, out num2))
            {
                throw new FormatException("Invalid format of second number");
            }

            if (num2 == 0)
            {
                throw new DivideByZeroException("Change second number value.\nYou can't divide by zero");
            }

            decimal result = num1 / num2;

            if (result > decimal.MaxValue || result < decimal.MinValue)
            {
                throw new OverflowException("Result is out of limits.");
            }

            return new DecimalString(result.ToString());
        }

        public bool IsGreaterThan(DecimalString other)
        {
            decimal num1;
            decimal num2;

            if (!decimal.TryParse(this.Str, out num1))
            {
                throw new FormatException("Invalid format of first number");
            }

            if (!decimal.TryParse(other.Str, out num2))
            {
                throw new FormatException("Invalid format of second number");
            }

            return num1 > num2;
        }

        public bool IsLessThan(DecimalString other)
        {
            decimal num1;
            decimal num2;

            if (!decimal.TryParse(this.Str, out num1))
            {
                throw new FormatException("Invalid format of first number");
            }

            if (!decimal.TryParse(other.Str, out num2))
            {
                throw new FormatException("Invalid format of second number");
            }

            return num1 < num2;
        }

        #endregion
    }
}
