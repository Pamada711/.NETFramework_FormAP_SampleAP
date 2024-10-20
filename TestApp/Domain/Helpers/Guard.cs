using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestApp.Domain.Exceptions;

namespace TestApp.Domain.Helpers
{
    public static class Guard
    {
        public static void IsNull(string text, string message)
        {
            if (text == "")
            {
                throw new InputException(message);
            }
        }

        public static int IsNumber(string text, string message)
        {
            int intValue;
            if (!int.TryParse(text, out intValue))
            {
                throw new InputException(message);
            }

            return intValue;
        }

        public static void IsOnlyAlphaNumeric(string text, string message)
        {
            if (!Regex.IsMatch(text, @"^[0-9a-zA-Z]+$"))
            {
                throw new InputException(message);
            }
        }
    }
}
