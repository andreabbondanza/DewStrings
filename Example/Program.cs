using System;
using DewExtensions;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "le persone guardano       i film al cinema  senza fare rumore";
            Console.WriteLine(first);
            Console.WriteLine("Capitalized:" + first.Capitalize());
            Console.WriteLine("Capitalized all:" + first.CapitalizeAllWords());
            Console.WriteLine("Is email? " + first.IsValidEmail());
            Console.WriteLine("Concat " + first.ConcatWithChar(first.Split(' '), ','));
            Console.WriteLine("Concat string " + first.ConcatWithString(first.Split(' '), " AND "));
            Console.WriteLine("Is null or empty? " + first.IsNullOrEmpty());
            Console.WriteLine("Remove first: " + first.RemoveFirstCharacter());
            Console.WriteLine("Remove last: " + first.RemoveLastCharacter());
            Console.WriteLine("Remove at 5: " + first.RemoveCharacterAt(5));
            Console.WriteLine("Random : " + first.RandomString().RemoveChar(' '));
            Console.WriteLine("Remove Space : " + first.RemoveChar(' '));
            Console.WriteLine("guard : " + first.HasSubstring("guard"));
            Console.WriteLine("guard : " + first.HasSubstring("Guard"));
            Console.WriteLine("guard : " + first.HasSubstringInsensitive("guard"));
            Console.WriteLine("guard : " + first.HasSubstringInsensitive("Guard"));
            Console.WriteLine("int : "+ "5".ToInt());
            Console.WriteLine("long : "+ "5".ToLong());
            Console.WriteLine("double : " + "5,54".ToDouble());
            Console.WriteLine("float : " + "5,364".ToFloat());
            Console.WriteLine("Word count : " + first.WordCount('i'));
            Console.WriteLine("Duplicate spaces: " + first.RemoveDuplicateSpaces());
            Console.ReadLine();
        }
    }
}