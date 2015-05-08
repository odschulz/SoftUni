using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object allWords = firstWord + " " + secondWord;
        string sentence = (string)allWords;
        Console.WriteLine(sentence + "!");
    }
}

