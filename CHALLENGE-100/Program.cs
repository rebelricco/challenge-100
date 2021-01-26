using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CHALLENGE_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lavet af Ricco Jørgensen den 25/01-2021\n\n");


            Console.WriteLine("challenge-101:");
            Console.WriteLine("[1, 50, 481, 22578255, 1, 58, 684635 ] -> [{0}]", string.Join(", ", FindMinMax(new int[] { 1, 50, 481, 22578255, 1, 58, 684635 })));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-102:");
            Console.WriteLine("Ricco Jørgensen -> " + NameShuffle("Ricco Jørgensen"));
            Console.WriteLine("Hans Hansen -> " + NameShuffle("Hans Hansen"));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-103:");
            Console.WriteLine("ALLCAPS -> " + SameCase("ALLCAPS"));
            Console.WriteLine("nocaps -> " + SameCase("nocaps"));
            Console.WriteLine("MixEdCapS -> " + SameCase("MixEdCapS"));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-104:");
            Console.WriteLine("password -> " + IsIsogram("password"));
            Console.WriteLine("pasword -> " + IsIsogram("pasword"));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-105:");
            Console.WriteLine("5 -> " + MonthName(5));
            Console.WriteLine("11 -> " + MonthName(11));
            Console.WriteLine("--------");

            Console.WriteLine("challenge-106:");
            Console.WriteLine("Hello, where are you? -> " + AlphabetIndex("Hello, where are you?"));
            Console.WriteLine("Hi, im over here! -> " + AlphabetIndex("Hi, im over here!"));
        }

        public static int[] FindMinMax(int[] intArray)
        {
            return new int[2] { intArray.Min(), intArray.Max() };
        }

        public static string NameShuffle(string name)
        {
            //Her ville jeg sikre at <name> altid skulle være et Fornavn og et efternavn.
            string[] splitName = name.Split(' ');
            return splitName[1] + " " + splitName[0];
        }

        public static bool SameCase(string caseSen)
        {
            if(caseSen.All(char.IsUpper) || caseSen.All(char.IsLower))
            {
                return true;
            }
            return false;
        }

        public static bool IsIsogram(string word)
        {
            if(word.ToLower().GroupBy(o => o).All(o => o.Count() == 1))
            {
                return true;
            }
            return false;
        }

        public static string MonthName(int monthNum)
        {
            //Her ville jeg sikre at <monthNum> er imellem 1 og 12
            return new DateTime(1, monthNum, 1).ToString("MMMM");
        }

        public static string AlphabetIndex(string sentence)
        {
            sentence = Regex.Replace(sentence, "[^a-zA-Z]", "");
            char[] chars = sentence.ToCharArray();
            List<int> alphabetIndex = new List<int>();
            foreach (char item in chars)
            {
                alphabetIndex.Add((char.ToUpper(item) - 64));
            }
            return string.Join(' ', alphabetIndex);
        }
    }
}
