using java.lang;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(findFirstRepeatedWords("Hell: hello my fellow candidate of my town."));
        }
        
        public static string findFirstRepeatedWords(string paragraph)
        {
            string[] charsToRemove = new string[] { ".", "=", ",", ";", "-", ":" };
            foreach (var xter in charsToRemove)
            {
                paragraph =  paragraph.Replace(xter, string.Empty).ToLower();
            }
            var splitedParagraph = paragraph.Split(' ');
            string wordCheck = null;
            var wordCount = splitedParagraph.Length;

            foreach (var word in splitedParagraph)
            {
                if (wordCheck == word)
                {
                    return word;
                }
                wordCheck = word;
                if (wordCount-- == 1)
                {
                    return "IllegalArgumentException";
                }
            }
            return null;
        }
    }
 }