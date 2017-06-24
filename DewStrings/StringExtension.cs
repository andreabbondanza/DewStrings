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
            return result.ConcatWithChar(words,' ');
        }
        /// <summary>
        /// Check if a string is empty or null
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return s == null || s == string.Empty;
        }
        /// <summary>
        /// Concat the current string with an array of string with selected character 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="concat"></param>
        /// <param name="strings"></param>
        /// <returns></returns>
        public static string ConcatWithChar(this string s, string[] strings, char concat = ' ')
        {
            var result = string.Empty;
            foreach (var item in strings)
            {
                result = result.ConcatWithChar(item, concat);
            }
            return result.RemoveFirstCharacter();
        }
        /// <summary>
        /// Concat the current string with selected character
        /// </summary>
        /// <param name="s"></param>
        /// <param name="toConcat"></param>
        /// <param name="concat"></param>
        /// <returns></returns>
        public static string ConcatWithChar(this string s, string toConcat, char concat = ' ')
        {
            return s + concat + toConcat;
        }
        /// <summary>
        /// Remove last character from the string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveLastCharacter(this string s)
        {
            return s.Substring(0, s.Length - 1);
        }
        /// <summary>
        /// Remove first caracter from the string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveFirstCharacter(this string s)
        {
            return s.Substring(1, s.Length-1);
        }
        /// <summary>
        /// Remove a character to a position
        /// </summary>
        /// <param name="s"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string RemoveCharacterAt(this string s, int index)
        {
            return s.Substring(0, index-1) + s.Substring(index, s.Length-index);
        }
    }
}
