using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OOPtask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string myInput = Console.ReadLine();

            Console.WriteLine("Введите целое число:");

            string tryMinValue = Console.ReadLine();
            int myMinValue;

            while (true)
            {
                if (!(int.TryParse(tryMinValue, out myMinValue)))
                {
                    Console.WriteLine("Введите минимальную длину слова (целое число)");
                    tryMinValue = Console.ReadLine();
                }

                else
                {
                    myMinValue = int.Parse(tryMinValue);
                    break;
                }
                
            }

            List<string> myList = ReturnWords(myInput, myMinValue);

            foreach (string word in myList)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
        public static List<string> ReturnWords(string userInput, int minValue)
        {
            List<char> charsToRemove = new List<char>() { '@', '_', ',', '.', '!', '?', '-', '+', ':', ';'};
            string newString = String.Concat(userInput.Split(charsToRemove.ToArray()));
            newString = Regex.Replace(newString, @"\s+", " ");

            string[] toWords = newString.Split(' ');
            List<string> tempList = new List<string>();
            foreach (string word in toWords)
            {
                if (word.Length>=minValue && !tempList.Contains(word.ToLower()))
                {
                    tempList.Add(word.ToLower());
                }
            }
            tempList.Sort();
            return tempList;
        }


    }
}
