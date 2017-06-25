using System;
using System.IO;
using System.Linq;
using System.Net;
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
            return result.ConcatWithChar(words, ' ');
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
        /// Concat directly the strings to the current
        /// </summary>
        /// <param name="s"></param>
        /// <param name="strings"></param>
        /// <param name="concat"></param>
        /// <returns></returns>
        public static string ConcatWithoutChar(this string s, string[] strings, char concat = ' ')
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
    }
}
