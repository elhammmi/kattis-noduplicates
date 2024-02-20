using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static string IsRepeated(string text)
        {
            var words = text.Split(" ");
            int numberOfRepeatedWords = 0;
            bool isRightFormat = true;
            if (text.Count() > 80)
            {
                return "invalid input";
            }
            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i].Any(char.IsUpper))
                {
                    isRightFormat = isRightFormat && true;
                }
                else
                {
                    isRightFormat = isRightFormat && false;
                    return "invalid input";
                }
            }
            if (isRightFormat)
            {
                for (int i = 0; i < words.Length - 1; i++)
                {
                    for (int j = i + 1; j < words.Length - 1; j++)
                    {
                        if (words[i] == words[j])
                        {
                            numberOfRepeatedWords++;
                        }
                    }

                }
            }
            if (numberOfRepeatedWords == 0)
            {
                return "Yes";

            }
            else
            {
                return "No";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number or 'ok' to end or enter your string: ");
            string input = "";
            string result = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input?.ToLower() == "ok")
                    break;
                result = IsRepeated(input);
                Console.WriteLine(result);
            }


        }
    }
}


