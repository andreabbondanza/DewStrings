using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace DewCore.Extensions.Strings
{
    /// <summary>
    /// An extension for strings
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Capitalize a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Capitalize(this string s)
        {
            if (!s.IsNullOrEmpty())
                return s.First().ToString().ToUpper() + s.Substring(1, s.Length - 1);
            return string.Empty;
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
                result = result.ConcatWithChar(item.Capitalize(), ' ');
            }
            return result;
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
        /// Concat the current string with selected string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="toConcat"></param>
        /// <param name="concat"></param>
        /// <returns></returns>
        public static string ConcatWithString(this string s, string toConcat, string concat = " ")
        {
            return s + concat + toConcat;
        }
        /// <summary>
        /// Concat directly the strings to the current
        /// </summary>
        /// <param name="s"></param>
        /// <param name="strings"></param>
        /// <returns></returns>
        public static string ConcatWithoutChar(this string s, string[] strings)
        {
            var result = string.Empty;
            foreach (var item in strings)
            {
                result = result.ConcatWithoutChar(item);
            }
            return result;
        }
        /// <summary>
        /// Contact directly the string to the current
        /// </summary>
        /// <param name="s"></param>
        /// <param name="toConcat"></param>
        /// <returns></returns>
        public static string ConcatWithoutChar(this string s, string toConcat)
        {
            return s + toConcat;
        }
        /// <summary>
        /// Concat the current string with selected string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="strings"></param>
        /// <param name="concat"></param>
        /// <returns></returns>
        public static string ConcatWithString(this string s, string[] strings, string concat = " ")
        {
            var result = string.Empty;
            foreach (var item in strings)
            {
                result = result.ConcatWithString(item, concat);
            }
            return result.Substring(concat.Length, result.Length - concat.Length);
        }
        /// <summary>
        /// Concat the current string with selected character
        /// </summary>
        /// <param name="s"></param>
        /// <param name="toConcat"></param>
        /// <param name="concat"></param>
        /// <returns></returns>
        public static string ConcatWithChar(this string s, string toConcat, string concat = " ")
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
            return s.Substring(1, s.Length - 1);
        }
        /// <summary>
        /// Remove a character to a position
        /// </summary>
        /// <param name="s"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string RemoveCharacterAt(this string s, int index)
        {
            return s.Substring(0, index - 1) + s.Substring(index, s.Length - index);
        }
        /// <summary>
        /// Generate a random string from the current string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RandomString(this string s)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(s, s.Length)
              .Select(x => x[random.Next(s.Length)]).ToArray());
        }
        /// <summary>
        /// Remove all occurence of a char from the string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="toRemove"></param>
        /// <returns></returns>
        public static string RemoveChar(this string s, char toRemove)
        {
            return s.ConcatWithoutChar(s.Split(toRemove));
        }
        /// <summary>
        /// Check if the string has a substring
        /// </summary>
        /// <param name="s"></param>
        /// <param name="substring"></param>
        /// <returns></returns>
        public static bool HasSubstring(this string s, string substring)
        {
            return Regex.IsMatch(s, @".*" + substring + @".*");
        }
        /// <summary>
        /// Check if the string has a substring, case insensitive
        /// </summary>
        /// <param name="s"></param>
        /// <param name="substring"></param>
        /// <returns></returns>
        public static bool HasSubstringInsensitive(this string s, string substring)
        {
            return Regex.IsMatch(s, @".*" + substring + @".*", RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// Return string as stream
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Stream ToStream(this string s)
        {
            return new MemoryStream(s.ToBytes());
        }
        /// <summary>
        /// Return string as bytes array
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this string s)
        {
            var bytes = new System.Text.UTF8Encoding().GetBytes(s);
            return bytes;
        }
        /// <summary>
        /// Return the string urlencoded
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToEncodedUrl(this string s)
        {
            return WebUtility.UrlEncode(s);
        }
        /// <summary>
        /// Return the string urldecoded
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToDecodedUrl(this string s)
        {
            return WebUtility.UrlEncode(s);
        }
        /// <summary>
        /// Check if the string is a valid http url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsValidHttpUrl(this string url)
        {
            bool Result = false;
            Uri MyUri = null;
            try
            {
                MyUri = new Uri(url);
            }
            catch (UriFormatException)
            {
                MyUri = null;
            }
            if (MyUri != null)
            {
                if (MyUri.Scheme.ToLower() == "http" || MyUri.Scheme.ToLower() == "https")
                    Result = true;
            }
            return Result;
        }
        /// <summary>
        /// Parse to int
        /// </summary>
        /// <param name="s"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static int ToInt(this string s, int def = 0)
        {
            int result = def;
            int.TryParse(s, out result);
            return result;
        }
        /// <summary>
        /// Parse to long
        /// </summary>
        /// <param name="s"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static long ToLong(this string s, long def = 0)
        {
            long result = def;
            long.TryParse(s, out result);
            return result;
        }
        /// <summary>
        /// Parse to double
        /// </summary>
        /// <param name="s"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static double ToDouble(this string s, double def = 0.0)
        {
            double result = def;
            double.TryParse(s, out result);
            return result;
        }
        /// <summary>
        /// Parse to float
        /// </summary>
        /// <param name="s"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static float ToFloat(this string s, float def = 0.0f)
        {
            float result = def;
            float.TryParse(s, out result);
            return result;
        }
        /// <summary>
        /// Count the word in the string (default separated by space)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static int WordCount(this string s, char separator = ' ')
        {
            var strings = s.Split(separator);
            int output = 0;
            foreach (var item in strings)
            {
                output = item.IsNullOrEmpty() ? output : output + 1;
            }
            return output;
        }
        /// <summary>
        /// Remove duplicated spaces and tabs
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveDuplicateSpaces(this string s)
        {
            var strings = s.Split(' ');
            string output = string.Empty;
            foreach (var item in strings)
            {
                if (!item.IsNullOrEmpty())
                    output = output + item + " ";
            }
            return output.RemoveLastCharacter();
        }
        /// <summary>
        /// Return the empty string (to prevent NullRefernceException)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToEmptyIfNull(this string s)
        {
            return s == null ? string.Empty : s;
        }
        /// <summary>
        /// Return the file extension for a path
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetFileExtension(this string s)
        {
            return Path.GetExtension(s);
        }
        /// <summary>
        /// Count the characters into a string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="character"></param>
        /// <returns></returns>
        public static int CountCharacters(this string s, char character = ' ')
        {
            return Regex.Matches(s, $"{character}").Count;
        }
        /// <summary>
        /// Quick match for regexp
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static bool IsMatch(this string s, string pattern, RegexOptions options = RegexOptions.None)
        {
            return Regex.IsMatch(s, pattern, options);
        }
        /// <summary>
        /// Quick check if string is a valid number
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumber(this string s)
        {
            return s.IsMatch("^[0-9]+[.,]{0,1}[0-9]*$");
        }
        /// <summary>
        /// Quick check if string is alphanumeric
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsAlphanumeric(this string s)
        {
            return s.IsMatch("^[a-zA-Z0-9]+$");
        }
        /// <summary>
        /// Quick check if string is alphabetic
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsAlphabetic(this string s)
        {
            return s.IsMatch("^[a-zA-Z]+$");
        }
        /// <summary>
        /// Return the ellipsis substring if string lenght is > than maxLength
        /// </summary>
        /// <param name="s"></param>
        /// <param name="maxLenght"></param>
        /// <returns></returns>
        public static string EllipsisEnd(this string s, int maxLenght)
        {
            return s.Length >= maxLenght ? s.Substring(0, maxLenght).TrimEnd().ConcatWithoutChar("...") : s;
        }
        /// <summary>
        /// Format a string with args
        /// </summary>
        /// <param name="s"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string Formatted(this string s, params object[] args)
        {
            return String.Format(s, args);
        }
        /// <summary>
        /// Return the specular
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Specular(this string s)
        {
            string result = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result = result.ConcatWithChar(string.Empty, s[i]);
            }
            return result;
        }
        /// <summary>
        /// Return a dictionary from a string with structure var{valueSeparator}val{separator}var1{valueSeparator}val1{separator}... (ex. a query string)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="valueSeparator"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetDictionary(this string s, char valueSeparator = '=', char separator = '&')
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var coll = s.Split(separator);
            foreach (var item in coll)
            {
                if (!item.IsNullOrEmpty())
                {
                    var curr = item.Split(valueSeparator);
                    if (curr.Length == 2)
                        dict.Add(item.Split(valueSeparator)[0], item.Split(valueSeparator)[1]);
                }
            }
            return dict;

        }
        /// <summary>
        /// Add slashes to ',",\
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string AddSlashes(this string s)
        {
            string q = "'";
            string dq = @"""";
            string sl = @"\";
            return s.Replace(sl, @"\\").Replace(q, @"\'").Replace(dq, "\\\"");
        }
        /// <summary>
        /// Return true if string is a palindrom (no case sensitive)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPalindrome(this string s)
        {
            if (s.RemoveChar(' ').ToLower() == s.RemoveChar(' ').Specular().ToLower())
                return true;
            return false;
        }
        /// <summary>
        /// Compact a string into a length
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Compact(this string s, int length)
        {
            var middle = (int)Math.Ceiling((double)(length - 3) / 2);
            return s.EllipsisEnd(middle).ConcatWithoutChar(s.Substring(s.Length - middle, middle));
        }
        /// <summary>
        /// Return true if string is a valid ipv4
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValidIpv4(this string s)
        {
            if (s != null)
                return Regex.IsMatch(s, @"^(2[0-5]{1}[0-5]{1}|1[0-9]{1}[0-9]{1}|[0-9]{1}[0-9]{1}|[0-9]{1})\.(2[0-5]{1}[0-5]{1}|1[0-9]{1}[0-9]{1}|[0-9]{1}[0-9]{1}|[0-9]{1})\.(2[0-5]{1}[0-5]{1}|1[0-9]{1}[0-9]{1}|[0-9]{1}[0-9]{1}|[0-9]{1})\.(2[0-5]{1}[0-5]{1}|1[0-9]{1}[0-9]{1}|[0-9]{1}[0-9]{1}|[0-9]{1})$");
            return false;
        }
        /// <summary>
        /// Return true if string is a valid ipv6
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValidIpv6(this string s)
        {
            if (s != null)
                return Regex.IsMatch(s, "");
            return false;
        }
        /// <summary>
        /// Encode string in html
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToHtmlEncode(this string s)
        {
            return WebUtility.HtmlEncode(s);
        }
        /// <summary>
        /// Decode string from html
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToHtmlDecode(this string s)
        {
            return WebUtility.HtmlDecode(s);
        }
        /// <summary>
        /// Generate batman logo :)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Batman(this string s)
        {
            return "" +
            "                   `-/.                                    `::.\n" +
            "               `:ohNMy`                                       :mNds /`        \n" +
            "            .+hMMMMMh                 :      /                 .MMMMMms -\n" +
            "          /dMMMMMMMMd                 do     +m                 :MMMMMMMMmo`          \n" +
            "        +NMMMMMMMMMMMd:               MM -``.NM`              `oMMMMMMMMMMMMs.\n" +
            "      :mMMMMMMMMMMMMMMMms:`           -MMMMMMMM/           .+ hMMMMMMMMMMMMMMMNo\n" +
            "     oMMMMMMMMMMMMMMMMMMMMMmyo /:.`   oMMMMMMMMs    `-:+sdNMMMMMMMMMMMMMMMMMMMMh`           \n" +
            "    sMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNmmNMMMMMMMMNdmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd`      \n" +
            "   / MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy\n" +
            "   dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.\n" +
            "   y +:-.````.:/ sdMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMmy +:-`````.:+s -\n" +
            "                 `/ dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNo.\n" +
            "                    + MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy`       \n" +
            "                     +ho /:-..-:+sdMMMMMMMMMMMMMMMMmyo / --.-- / oyh\n" +
            "                                  `/ hMMMMMMMMMMm +.\n" +
            "                                     .hMMMMMMm:                                             \n" +
            "                                       :NMMMo\n" +
            "                                        .mM /\n" +
            "                                         ./";






        }
    }
}
