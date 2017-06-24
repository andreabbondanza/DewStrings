using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DewExtensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Capitalize a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Capitalize(this string s)
        {
            return s.First().ToString().ToUpper() + s.Substring(1, s.Length - 1);
        }
        /// <summary>
        /// Check if a mail is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(this string email)
        {
            if (email != null)
                return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return false;
        }

        /// <summary>
        /// Capitalize all words in a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string CapitalizeAllWords(this string s)
        {
            var words = s.Split(' ');
            var result = string.Empty;
            foreach (var item in words)
            {
                result = result + item.Capitalize() + " ";
            }
            return s.Substring(0, s.Length - 1);
        }
    }
}
