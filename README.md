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
- __ToEncodeUrl__ : Encode the url
- __ToDecodeUrl__ : Decode the url
- __IsValidHttpUrl__ : Check if the string is a valid HTTP Url

##### Note: This is a class estension
You can use it with dot notation from a string, 
```c#
var myString = "pippo".Capitalize();
//now myString is "Pippo"
```
## NuGet
You can find it on nuget with the name [DewStrings](https://www.nuget.org/packages/DewStrings)

## About
[Andrea Vincenzo Abbondanza](http://www.andrewdev.eu)

## Donate
[Help me to grow up, if you want](https://payPal.me/andreabbondanza)

