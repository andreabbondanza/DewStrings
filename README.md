# DewStrings

An extension for the string class in .net

## Methods

- __Capitalize__ : Capitalize the string
- __CapitalizeAllWords__ : Capitalize all the words into a string (separated by spaces)
- __IsValidEmail__ : Check if the string is a valid mail
- __IsNullOrEmpty__ : Check if the string is null or empty
- __ConcatWithChar__ : Concat the current string with another, using a specified character
- __ConcatWithChar__ : Concat the current string with other strings, using a specified character
- __ConcatWithoutChar__ : Concat the current string with another without a character
- __ConcatWithoutChar__ : Concat the current string with other strings without a character
- __RemoveLastCharacter__ : Remove the last character
- __RemoveFirstCharacter__ : Remove the first character
- __RemoveCharacterAt__ : Remove character at position x
- __RandomString__ : Get a random string generated from the current (same length)
- __RemoveChar__ : Remove all occurences of a character from the string
- __HasSubstring__ : Check if the string has a substring (case sensitive)
- __HasSubstringInsensitive__ : Check if the string has a substring (case insensitive)
- __ToStream__ : Convert string to stream
- __ToBytes__ : Convert string to bytes array
- __ToEncodedUrl__ : Encode the url
- __ToDecodedUrl__ : Decode the url
- __IsValidHttpUrl__ : Check if the string is a valid HTTP Url
- __ToInt__: Return the string like an int (default value args)
- __ToLong__: Return the string like an long (default value args)
- __ToDouble__: Return the string like an double (default value args)
- __ToFloat__: Return the string like an float (default value args)
- __WordCount__ : Count the word in a string
- __RemoveDuplicateSpaces__ : Remove duplicated spaces and tabs
- __ToEmptyIfNull__ : Return the empty string (to prevent NullRefernceException)
- __GetFileExtension__ : Return the file extension for a path
- __CountCharacters__ : Return the number of characters into the string
- __IsMatch__ : Quick match for regexp
- __IsNumber__ : Quick check if string is a valid number
- __IsAlphanumeric__ : Quick check if string is alphanumeric
- __IsAlphabetic__ : Quick check if string is alphabetic
- __EllipsisEnd__ : Add the ellipsis if the string has length > maxLength
- __Formatted__ : Return the string formatted with the arguments
- __Specular__ : Return the specular string
- __GetDictionary__ : Return a dictionary from a string with structure var{valueSeparator}val{separator}var1{valueSeparator}val1{separator}... (ex. a query string)
- __AddSlashes__ : Add slashes to \\,',"
- __IsPalindrome__ : return true if the string is a palindrome
- __Compact__ : Compat the string in the passed lenght.
- __Alternative__ : Return an alternative text if string is empty
- __ToHtmlDecode__ : Return the html decoded string
- __ToHtmlEncode__ : Return encoded html string
- __Camelize__ : Return the camelized string
- __IsValidPassword__ : Check if a string is  avalid password
- __GetHashString__ : Get hashed string 

##### Note: This is a class estension
You can use it with dot notation from a string, 
```c#
var myString = "pippo".Capitalize();
//now myString is "Pippo"
var today = "today is  a great day and i'm here!".RemoveDuplicateSpaces().CapitalizeAllWords();
//now today is "Today Is A Great Day And I'm Here!"
```
## NuGet
You can find it on nuget with the name [DewStrings](https://www.nuget.org/packages/DewStrings)

## About
[Andrea Vincenzo Abbondanza](http://www.andrewdev.eu)

## Donate
[Help me to grow up, if you want](https://payPal.me/andreabbondanza)

