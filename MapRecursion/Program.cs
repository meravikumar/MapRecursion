using System;
using System.Collections.Generic;

namespace MapRecursion
{
    public class Program
    { 
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a  integer number: ");
                string input = Console.ReadLine();

                List<string> combinations = GetCombinations(input);

                Console.WriteLine("All Possible combinations:");
                foreach (var combination in combinations)
                {
                    Console.WriteLine(combination);
                }
            }

            static List<string> GetCombinations(string digits)
            {
                if (string.IsNullOrEmpty(digits))
                    return new List<string>();

                List<string> result = new List<string>();
                GenerateCombinations(digits, 0, "", result);
                return result;
            }

            static void GenerateCombinations(string digits, int index, string currentCombination, List<string> result)
            {
                if (index == digits.Length)
                {
                    result.Add(currentCombination);
                    return;
                }

                int digit1 = digits[index] - '0';
               // Console.WriteLine("digits="+digit1);
                if (digit1 >= 1 && digit1 <= 9)
                {
                    char letter1 = (char)('a' + digit1 - 1);
                    GenerateCombinations(digits, index + 1, currentCombination + letter1, result);
                }

                if (index + 1 < digits.Length)
                {
                    int digit2 = int.Parse(digits.Substring(index, 2));
                    if (digit2 >= 10 && digit2 <= 26)
                    {
                        char letter2 = (char)('a' + digit2 - 1);
                        GenerateCombinations(digits, index + 2, currentCombination + letter2, result);
                    }
                }
            }

    }
}
